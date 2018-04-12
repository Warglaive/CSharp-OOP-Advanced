using System;
using System.Linq;

namespace _03.IteratorTest
{
    class Program
    {
        static void Main()
        {
            try
            {
                var create = Console.ReadLine().Split();
                var arrInput = create.Skip(1).ToArray();

                var iterator = new ListIterator(arrInput);

                var input = Console.ReadLine();
                while (input != "END")
                {
                    var inputArgs = input.Split();
                    var command = inputArgs[0];

                    switch (command)
                    {
                        case "Move":
                            Console.WriteLine(iterator.Move());
                            break;
                        case "HasNext":
                            Console.WriteLine(iterator.HasNext());
                            break;
                        case "Print":
                            iterator.Print();
                            break;
                    }
                    input = Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}