using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var persons = new List<Person>();
        var input = Console.ReadLine();
        while (input != "END")
        {
            var arguments = input.Split();
            var name = arguments[0];
            var age = int.Parse(arguments[1]);
            var town = arguments[2];

            var currentPerson = new Person(name, age, town);
            persons.Add(currentPerson);

            input = Console.ReadLine();
        }
        var personIndex = int.Parse(Console.ReadLine());

        if (personIndex > 0)
        {
            personIndex -= 1;
        }

        var equalsCount = 0;
        var notEqualsCount = 0;

        foreach (var listedPerson in persons)
        {
            if (persons.IndexOf(listedPerson) == personIndex)
            {
                continue;
            }
            if (listedPerson.CompareTo(persons[personIndex]) == 0)
            {
                equalsCount++;
            }
            else
            {
                notEqualsCount++;
            }
        }

        if (equalsCount == 0)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{equalsCount + 1} {notEqualsCount} {persons.Count}");
        }
    }
}