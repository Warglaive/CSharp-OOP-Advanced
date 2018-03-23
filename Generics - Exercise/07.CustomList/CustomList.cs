using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class CustomList<T> where T : IComparable
{
    private List<T> result;

    public CustomList()
    {
        this.result = new List<T>();
    }

    public void Add(T element)
    {
        this.result.Add(element);
    }

    public void Remove(int index)
    {
        this.result.RemoveAt(index);
    }

    public bool Contains(T element)
    {
        return this.result.Contains(element);
    }

    public int CountGreater(T element)
    {
        var counter = 0;
        foreach (var listedElement in this.result)
        {
            if (listedElement.CompareTo(element) == 1)
            {
                counter++;
            }
        }
        return counter;
    }

    public T Max()
    {
        return this.result.Max();
    }

    public T Min()
    {
        return this.result.Min();
    }

    public void SwapElement(int firstIndex, int secondIndex)
    {
        var temp = this.result[firstIndex];
        this.result[firstIndex] = this.result[secondIndex];
        this.result[secondIndex] = temp;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var currentElement in this.result)
        {
            sb.AppendLine(currentElement.ToString());
        }
        return sb.ToString();
    }
}