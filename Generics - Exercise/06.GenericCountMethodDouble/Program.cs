using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var elements = new List<double>();
        for (int i = 0; i < n; i++)
        {
            var element = double.Parse(Console.ReadLine());
            elements.Add(element);
        }
        var lastElement = double.Parse(Console.ReadLine());
        var counter = new Counter<double>();
        Console.WriteLine(counter.Count(elements, lastElement));
    }
}