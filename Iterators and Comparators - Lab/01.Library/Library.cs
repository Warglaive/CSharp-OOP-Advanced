﻿using System.Collections;
using System.Collections.Generic;

public class Library : IEnumerable<Book>
{
    public List<Book> books { get; }

    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return this.books.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}