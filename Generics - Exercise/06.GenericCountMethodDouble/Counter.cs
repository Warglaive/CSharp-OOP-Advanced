using System;
using System.Collections.Generic;
using System.Text;


public class Counter<T> where T : IComparable
{
    public int Count(List<T> arguments, T element)
    {
        var counter = 0;
        foreach (var listedElement in arguments)
        {
            if (listedElement.CompareTo(element) == 1)
            {
                counter++;
            }
        }
        return counter;
    }
}