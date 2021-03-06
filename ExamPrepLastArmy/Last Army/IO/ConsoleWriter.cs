﻿using System;
using System.Text;

class ConsoleWriter : IWriter
{
    private StringBuilder stringBuilder;

    public ConsoleWriter()
    {
        this.stringBuilder = new StringBuilder();
    }

    public void AppendLine(string line)
    {
        stringBuilder.AppendLine(line);
    }

    public void WriteLineAll()
    {
        Console.WriteLine(stringBuilder.ToString().Trim());
    }
}