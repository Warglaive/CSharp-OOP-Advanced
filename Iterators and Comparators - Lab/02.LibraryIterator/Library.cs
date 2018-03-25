using System.Collections;
using System.Collections.Generic;

public class Library : IEnumerable<Book>
{
    public List<Book> books { get; }

    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
    }

    public class LibraryIterator : IEnumerable<Book>
    {
        public List<Book> books { get; }
        public int currentIndex { get; }

        public IEnumerator<Book> GetEnumerator()
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
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