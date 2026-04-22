// <copyright file="Spinner.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Diagnostics;

namespace ExtractIPs;

internal class Spinner
{
    private long _lastUpdateTimestamp;
    private int _counter;
    // Последовательность символов в стиле современных CLI

    private static readonly string[] _sequence = { "⠋", "⠙", "⠹", "⠸", "⠼", "⠴", "⠦", "⠧", "⠇", "⠏" };

    public void Turn(string message)
    {
        if (Stopwatch.GetElapsedTime(_lastUpdateTimestamp).TotalMilliseconds < 100)
        {
            return;
        }
        _lastUpdateTimestamp = Stopwatch.GetTimestamp();
        _counter++;
        // \r возвращает курсор в начало, сообщение перезаписывается
        Console.Write($"\r{_sequence[_counter % _sequence.Length]} {message}");
    }

    public static void Done(string finalMessage = "Готово!")
    {
        // Очищаем строку перед выводом финального сообщения
        Console.Write($"\r✔\n");
        Console.WriteLine($"✔ {finalMessage}");
    }
}
