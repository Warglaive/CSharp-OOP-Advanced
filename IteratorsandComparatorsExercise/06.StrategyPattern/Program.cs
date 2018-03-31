using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var nameLengthComparator = new NameLengthComparator();
        var ageComparatorClass = new AgeComparator();

        var nameComparator = new SortedSet<Person>(nameLengthComparator);
        var ageComparator = new SortedSet<Person>(ageComparatorClass);

        var N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            var input = Console.ReadLine().Split();
            var name = input[0];
            var age = int.Parse(input[1]);
            var firstPerson = new Person(name, age);

            nameComparator.Add(firstPerson);

            ageComparator.Add(firstPerson);

        }
        foreach (var person in nameComparator)
        {
            Console.WriteLine(person);
        }

        foreach (var person in ageComparator)
        {
            Console.WriteLine(person);
        }
    }
}