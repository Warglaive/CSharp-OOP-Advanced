using System;
using System.Text;

public class ConsoleWriter : IWriter
{
    private StringBuilder stringBuilder;

    public ConsoleWriter()
    {
        this.stringBuilder = new StringBuilder();
    }
    public void AppendLine(string line)
    {
        //bug maybe
        this.stringBuilder.AppendLine(line);
    }

    public string WriteAllLines()
    {
        return stringBuilder.ToString().Trim();
    }
}