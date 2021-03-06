﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Library : IEnumerable<Book>
{
    private SortedSet<Book> books;
    private IComparer<Book> comparer;

    public Library(params Book[] books)
    {
        this.comparer = new BookComparator();
        this.books = new SortedSet<Book>(this.comparer);
        this.books.UnionWith(books);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(this.books);
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    private class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int currentIndex;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        public bool MoveNext() => ++currentIndex < this.books.Count;
        public void Reset()
        {
            this.currentIndex = -1;
        }

        public Book Current => this.books[currentIndex];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}