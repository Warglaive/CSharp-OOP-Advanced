using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var elements = new List<string>();
        for (int i = 0; i < n; i++)
        {
            var element = Console.ReadLine();
            elements.Add(element);
        }
        var lastElement = Console.ReadLine();
        var counter = new Counter<string>();
        Console.WriteLine(counter.Count(elements, lastElement));
    }
}