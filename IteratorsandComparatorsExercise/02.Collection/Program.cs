using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var arguments = new List<string>();
        var listyIterator = new ListyIterator<string>(arguments);
        while (input != "END")
        {
            try
            {
                var command = input.Split()[0];

                arguments = input.Split().Skip(1).ToList();
                if (command == "Create")
                {
                    listyIterator.Collection = arguments;
                }

                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "Print":
                        listyIterator.Print();
                        break;
                    case "PrintAll":
                        listyIterator.PrintAll();
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            input = Console.ReadLine();
        }
    }
}