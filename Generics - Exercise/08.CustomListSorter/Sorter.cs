using System;
using System.Collections.Generic;
using System.Text;


public class Sorter<T> where T : IComparable
{
    public static CustomList<T> Sort(CustomList<T> customList)
    {
        var sortedCustomList = customList;

        sortedCustomList.Sort();

        return sortedCustomList;
    }
}