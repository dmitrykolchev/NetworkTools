# Инструкции по запуску WfpConnectionMonitor

## ⚠️ ВАЖНЫЕ ТРЕБОВАНИЯ

### Администраторские права (ОБЯЗАТЕЛЬНО!)

Приложение **ДОЛЖНО** быть запущено с правами администратора, иначе WFP API вернет ошибку 50 (ERROR_NOT_SUPPORTED).

## Компиляция

```powershell
cd C:\Projects\2026\NetworkTools

# Компиляция проекта
dotnet build src\ConnectionMonitor\ConnectionMonitor.csproj
```

## Запуск

### Способ 1: С правами администратора через PowerShell

```powershell
# Запустить PowerShell как администратор, затем:
cd C:\Projects\2026\NetworkTools
dotnet run --project src\ConnectionMonitor\ConnectionMonitor.csproj
```

### Способ 2: Прямое выполнение файла

```powershell
# С правами администратора
C:\Projects\2026\NetworkTools\src\ConnectionMonitor\bin\Debug\net10.0\ConnectionMonitor.exe
```

## Использование

Когда приложение запустится, оно будет:
1. Инициализировать WFP (Windows Filtering Platform)
2. Подписаться на события уровня ALE_AUTH_CONNECT_V4
3. Выводить IP-адреса удаленных хостов при попытке подключения

Пример вывода:
```
Starting connection monitor...
Note: This application requires administrator privileges to run.

Monitoring outgoing connections. Press Enter to exit...
Remote IP: 8.8.8.8
Remote IP: 1.1.1.1
Remote IP: 142.250.185.46
```

Для выхода нажмите **Enter**.

## Решение проблем

### Error 50 (ERROR_NOT_SUPPORTED)
**Причина**: Приложение запущено без прав администратора
**Решение**: Запустите PowerShell как администратор и повторите команду

### Error 5 (ERROR_ACCESS_DENIED)
**Причина**: Недостаточные права или конфликт с другой программой
**Решение**: 
- Убедитесь, что запущены от администратора
- Закройте другие приложения, работающие с WFP

### Приложение зависает при запуске
**Причина**: Медленная инициализация WFP
**Решение**: Дождитесь загрузки (может занять несколько секунд)

## Структура кода

```
src/ConnectionMonitor/
├── Program.cs                 # Основной класс WfpConnectionMonitor
├── ConnectionMonitor.csproj   # Файл проекта
└── README.md                  # Подробная документация
```

## Архитектура

- **WfpConnectionMonitor**: Основной класс для мониторинга
  - `Start()`: Инициализирует WFP и начинает мониторинг
  - `Dispose()`: Очищает ресурсы и закрывает соединение с WFP

- **NetEventCallback**: Static unmanaged callback для получения событий из ядра

- **ProcessEventsSync**: Обработчик событий в фоновом потоке

## Примеры использования

### Базовое использование
```csharp
var monitor = new WfpConnectionMonitor();
monitor.OnConnectionAttempt += ip => 
{
    Console.WriteLine($"Connection to: {new System.Net.IPAddress(ip)}");
};
monitor.Start();
Console.ReadLine();
monitor.Dispose();
```

### С обработкой ошибок
```csharp
try
{
    var monitor = new WfpConnectionMonitor();
    monitor.OnConnectionAttempt += HandleConnection;
    monitor.Start();
    // ... процесс работает ...
    monitor.Dispose();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"WFP ошибка: {ex.Message}");
}
```

## Производительность

- Обработка события: < 1ms
- Максимум событий в буфере: 10 000
- Переполнение буфера: Отбрасываются старые события
- Потокобезопасность: Обеспечена через Channel<T>

## Лицензия

Copyright (c) 2026 Dmitry Kolchev
