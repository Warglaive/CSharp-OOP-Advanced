using System;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        var sorted = new SortedSet<Person>();
        var hash = new HashSet<Person>();

        var N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            var input = Console.ReadLine().Split();
            var name = input[0];
            var age = int.Parse(input[1]);
            var person = new Person(name, age);
            sorted.Add(person);
            hash.Add(person);
        }
        Console.WriteLine(sorted.Count);
        Console.WriteLine(hash.Count);
    }
}