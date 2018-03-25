using System.Collections.Generic;

public class Library
{
    public List<Book> books { get; }

    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
    }
}