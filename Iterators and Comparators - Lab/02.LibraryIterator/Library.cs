﻿using System;
using System.Collections;
using System.Collections.Generic;

public class Library : IEnumerable<Book>
{
    private List<Book> books { get; }

    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
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

        public bool MoveNext()
        {
            if (++currentIndex > this.books.Count)
            {
                return false;
            }
            return true;
        }

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