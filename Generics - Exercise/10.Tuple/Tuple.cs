using System;
using System.Collections.Generic;
using System.Text;

public class Tuple<T>
{
    private object Item1 { get; set; }
    private object Item2 { get; set; }

    public Tuple(T item1, T item2)
    {
        this.Item1 = item1;
        this.Item2 = item2;
    }
}