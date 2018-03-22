using System;
public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var input = string.Empty;
        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine();
            var b = new Box<string>(input);
            Console.WriteLine(b);
        }
    }
}