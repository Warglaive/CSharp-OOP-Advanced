using System.Collections.Generic;

public class AgeComparator : IComparer<Person>
{
    public int Compare(Person firstPerson, Person secondPerson)
    {
        var result = firstPerson.Age.CompareTo(secondPerson.Age);
        return result;
    }
}