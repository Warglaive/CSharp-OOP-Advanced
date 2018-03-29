using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var commands = input.Split(new[] { ' ', ',' }
        , StringSplitOptions.RemoveEmptyEntries).ToList();

        var arguments = new List<string>();
        var stack = new Stack<string>(arguments);
        try
        {
            while (input != "END")
            {
                commands = input.Split(new[] { ' ', ',' }
                    , StringSplitOptions.RemoveEmptyEntries).ToList();

                var command = commands[0];

                if (command == "Push")
                {
                    arguments = commands.Skip(1).ToList();
                    stack.Push(arguments);
                }
                else if (command == "Pop")
                {
                    stack.Pop();
                }


                input = Console.ReadLine();
                if (input == "END")
                {
                    foreach (var element in stack)
                    {
                        Console.WriteLine(element);
                    }
                    foreach (var element in stack)
                    {
                        Console.WriteLine(element);
                    }
                }
            }
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("No elements");
        }
    }
}