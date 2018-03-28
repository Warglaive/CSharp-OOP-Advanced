using System;
using System.Collections.Generic;
using System.Text;

public class ListyIterator<T>
{
    public List<T> Collection { get; set; }
    public int currentIndex;


    public ListyIterator(List<T> collection)
    {
        this.Collection = collection;
    }
    public void Move()
    {
        currentIndex++;
    }
}