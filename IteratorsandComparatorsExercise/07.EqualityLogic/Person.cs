using System;
using System.Collections.Generic;
using System.Text;

public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public override bool Equals(object obj)
    {
        var other = (Person)obj;
        return this.Name == other.Name && this.Age == other.Age;

    }

    public override int GetHashCode()
    {
        return this.Name.GetHashCode() + this.Age.GetHashCode();
    }

    public int CompareTo(Person other)
    {
        var compareResult = this.Name.CompareTo(other.Name);
        if (compareResult == 0)
        {
            compareResult = this.Age.CompareTo(other.Age);
        }
        return compareResult;
    }
}