﻿using System;
using System.Collections.Generic;
using System.Linq;

public class ListyIterator<T>
{
    public List<T> Collection { get; set; }
    public int currentIndex;


    public ListyIterator(List<T> collection)
    {
        this.Collection = collection;
        currentIndex = 0;
    }

    public bool Move()
    {
        if (currentIndex + 1 < this.Collection.Count)
        {
            currentIndex++;
            return true;
        }
        return false;
    }

    public bool HasNext()
    {
        if (currentIndex + 1 < this.Collection.Count)
        {
            return true;
        }
        return false;
    }

    public void Print()
    {
        if (!this.Collection.Any())
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        Console.WriteLine(this.Collection[this.currentIndex]);
    }
}