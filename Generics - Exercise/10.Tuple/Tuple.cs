using System;
using System.Collections.Generic;
using System.Text;

public class Tuple<T>
{
    public object Item1 { get; set; }
    public object Item2 { get; set; }

    public Tuple(T item1, T item2)
    {
        this.Item1 = item1;
        this.Item2 = item2;
    }
}