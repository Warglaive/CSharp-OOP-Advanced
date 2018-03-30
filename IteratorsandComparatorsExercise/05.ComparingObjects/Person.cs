using System;
using System.Collections.Generic;
using System.Text;

public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Town { get; set; }

    public Person(string name, int age, string town)
    {
        this.Name = name;
        this.Age = age;
        this.Town = town;
    }

    public int CompareTo(Person other)
    {
        var compareResult = this.Name.CompareTo(other.Name);

        if (compareResult == 0)
        {
            compareResult = this.Age.CompareTo(other.Age);
            if (compareResult == 0)
            {
                compareResult = this.Town.CompareTo(other.Town);
                if (compareResult == 0)
                {
                    return compareResult;
                }
            }
        }
        return compareResult;
    }
}