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
        this.stringBuilder.AppendLine(line.Trim());
    }

    public string WriteAllLines()
    {
        return this.stringBuilder.ToString().Trim();
    }

    public void Clear()
    {
        this.stringBuilder.Clear();
    }
}