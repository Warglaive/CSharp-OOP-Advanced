using System;
using System.Text;


public class Program
{
    public static void Main()
    {
        Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
        Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
        Book bookThree = new Book("The Documents in the Case", 1930);

        string expectedOutput = $"{bookThree.Title} - {bookThree.Year}" + Environment.NewLine +
                                $"{bookTwo.Title} - {bookTwo.Year}" + Environment.NewLine +
                                $"{bookOne.Title} - {bookOne.Year}";

        Library library = new Library(bookOne, bookTwo, bookThree);
        StringBuilder sb = new StringBuilder();
        foreach (var book in library)
        {
            sb.AppendLine(book.ToString());
        }
    }
}