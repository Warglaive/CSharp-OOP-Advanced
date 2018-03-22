using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var elements = new List<int>();
        for (int i = 0; i < n; i++)
        {
            var element = int.Parse(Console.ReadLine());
            elements.Add(element);
        }
        var indexes = Console.ReadLine().Split().Select(int.Parse).ToList();
        var firstIndex = indexes[0];
        var secondIndex = indexes[1];
        var swapper = new SwapIntegers<int>();
        swapper.SwapElement(elements, firstIndex, secondIndex);
        Console.Write(swapper);
    }
}