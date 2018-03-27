using System;


public class Program
{
    public static void Main()
    {
        Book bookOne = new Book("Animal Farm", 1930, "George Orwell");
        Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
        Book bookThree = new Book("The Documents in the Case", 2003);
        var l = new Library(bookOne,bookTwo,bookThree);
        BookComparator bc = new BookComparator();
    }
}