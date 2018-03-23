using System;
using System.Linq;


public class Program
{
    public static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            var input = Console.ReadLine().Split();
            object item1 = input[0];
            object item2 = input.Last();

            if (input.Length > 2)
            {
                item1 += " " + input[1];
            }

            Tuple<object, object> test
                = new Tuple<object, object>(item1, item2);

            Console.WriteLine($"{test.Item1} -> {test.Item2}");
        }
    }
}