# WfpConnectionMonitor - Windows Filtering Platform IPv4 Connection Monitor

Данное приложение позволяет отслеживать установку исходящих IPv4 соединений через Windows Filtering Platform (WFP) в пользовательском режиме.

## Требования

- **ОС**: Windows Vista или выше
- **Права**: Администратор (обязательно!)
- **.NET**: .NET 10
- **Платформа**: x64

## Описание функциональности

Класс `WfpConnectionMonitor` использует WFP API для подписки на события уровня `FWPM_LAYER_ALE_AUTH_CONNECT_V4` и получает IP-адреса удаленных хостов при установке соединений.

## Основные исправления в коде

### 1. **Callback сигнатура (FWPM_NET_EVENT1_)**
Callback функция должна работать с `FWPM_NET_EVENT1_*` вместо `FWPM_NET_EVENT0_*`, поскольку это новая версия структуры с правильными полями.

### 2. **Доступ к IP-адресу из события**
IP-адрес находится в заголовке события:
```csharp
uint remoteIp = eventPtr->header.Anonymous2.remoteAddrV4;
```

### 3. **Инициализация FWPM_SESSION0_**
Структура сессии должна быть полностью инициализирована со всеми полями:
```csharp
var session = new FWPM_SESSION0_
{
    sessionKey = Guid.NewGuid(),
    displayData = new FWPM_DISPLAY_DATA0_ { name = ... },
    flags = 0x00000001,  // FWPM_SESSION_FLAG_DYNAMIC
    txnWaitTimeoutInMSec = 0,
    processId = 0,
    sid = null,
    username = null,
    kernelMode = 0
};
```

### 4. **Управление памятью для строк**
Строки должны быть выделены через `Marshal.StringToHGlobalUni()` и освобождены в `Dispose()`:
```csharp
_sessionNamePtr = Marshal.StringToHGlobalUni("Bypass Monitor Session");
// ... 
Marshal.FreeHGlobal(_sessionNamePtr);
```

### 5. **Async/await в unsafe контексте**
Нельзя использовать `await` в `unsafe` методах. Решение - обработка событий в отдельном рабочем потоке:
```csharp
private Task ProcessEventsAsync(CancellationToken ct)
{
    return Task.Run(() => ProcessEventsSync(ct), ct);
}
```

### 6. **Управление указателями на GUID'ы**
При передаче `Guid*` параметров используется локальная переменная:
```csharp
Guid providerKeyForSubLayer = _providerGuid;
subLayer.providerKey = &providerKeyForSubLayer;
```

## Использование

```csharp
using (var monitor = new WfpConnectionMonitor())
{
    monitor.OnConnectionAttempt += ip => 
    {
        var ipAddr = new System.Net.IPAddress(ip);
        Console.WriteLine($"Connection to: {ipAddr}");
    };

    monitor.Start();

    // ... ждет соединений ...
}
```

## Обработка ошибок

- **Error 50 (ERROR_NOT_SUPPORTED)**: Приложение должно быть запущено с правами администратора
- **Error 5 (ERROR_ACCESS_DENIED)**: Проверьте права доступа

## GUID'ы слоев

- `FWPM_LAYER_ALE_AUTH_CONNECT_V4`: `70e5ad3d-6f6e-4d80-b6c3-28f2eec08997`
- Используется для мониторинга попыток подключения на транспортном уровне

## Примечания

1. Приложение создает динамическую сессию WFP, которая удаляется при закрытии
2. События обрабатываются через канал (Channel<T>) для безопасности потоков
3. Максимум 10000 событий хранится в буфере (остальные отбрасываются)
4. Callback вызывается из ядра Windows с приоритетом, поэтому должен быть максимально быстрым
