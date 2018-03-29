using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Stack<T> : IEnumerable<T>
{
    public List<T> Collection { get; set; }

    public Stack(List<T> collection)
    {
        this.Collection = collection;
    }

    public void Push(List<T> elements)
    {
        foreach (var element in elements)
        {
            this.Collection.Add(element);
        }
    }

    public T Pop()
    {
        var result = this.Collection.Last();
        this.Collection.RemoveAt(this.Collection.Count - 1);
        return result;
    }


    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.Collection.Count - 1; i >= 0; i--)
        {
            yield return this.Collection[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}