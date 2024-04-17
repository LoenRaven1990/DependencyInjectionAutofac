﻿using Library.Utilities.Interfaces;

namespace Library.Utilities;
public class Logger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging: {message}");
    }
}
