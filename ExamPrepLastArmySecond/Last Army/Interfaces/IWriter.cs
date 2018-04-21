public interface IWriter
{
    void AppendLine(string line);
    string WriteAllLines();
    void Clear();
}