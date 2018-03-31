using System;
using System.Collections.Generic;
using System.Text;


public class NameLengthComparator : IComparer<Person>
{
    public int Compare(Person firstPerson, Person secondPerson)
    {
        var firstName = firstPerson.Name;
        var secondName = secondPerson.Name;

        var result = firstName.Length.CompareTo(secondName.Length);
        if (result == 0)
        {
            result = firstName.ToLower()[0].CompareTo(secondName.ToLower()[0]);
        }
        return result;
    }
}

