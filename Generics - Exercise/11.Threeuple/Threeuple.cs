using System;
using System.Collections.Generic;
using System.Text;


public class Threeuple<T, T2, T3>
{
    public object Item1 { get; set; }
    public object Item2 { get; set; }
    public object Item3 { get; set; }

    public Threeuple(T item1, T2 item2, T3 item3)
    {
        this.Item1 = item1;
        this.Item2 = item2;
        this.Item3 = item3;
    }
    public override string ToString()
    {
        return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
    }
}