using System.Collections.Generic;

public class Box<T>
{
    private List<T> data;

    public int Count => data.Count;

    public Box()
    {
        this.data = new List<T>();
    }

    public void Add(T element)
    {
        data.Insert(0, element);
    }

    public T Remove()
    {
        var el = data[0];
        data.RemoveAt(0);
        return el;
    }
}