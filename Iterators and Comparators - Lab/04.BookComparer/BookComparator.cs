﻿using System;
using System.Collections.Generic;
using System.Text;


public class BookComparator : IComparer<Book>
{
    public int Compare(Book firstBook, Book secondBook)
    {
        var result = firstBook.Title.CompareTo(secondBook.Title);
        if (result == 0)
        {
            result = secondBook.Year.CompareTo(firstBook.Year);
        }
        return result;
    }
}