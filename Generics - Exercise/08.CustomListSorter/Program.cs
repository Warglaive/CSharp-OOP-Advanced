using System;

public class Program
{
    public static void Main()
    {
        var customList = new CustomList<string>();
        var input = Console.ReadLine().Split();
        var command = input[0];
        while (command != "END")
        {
            switch (command)
            {
                case "Add":
                    var element = input[1];
                    customList.Add(element);
                    break;
                case "Remove":
                    var index = int.Parse(input[1]);
                    customList.Remove(index);
                    break;
                case "Contains":
                    var containsElement = input[1];
                    Console.WriteLine(customList.Contains(containsElement));
                    break;
                case "Swap":
                    var firstIndex = int.Parse(input[1]);
                    var secondIndex = int.Parse(input[2]);
                    customList.SwapElement(firstIndex, secondIndex);
                    break;
                case "Greater":
                    var greaterElement = input[1];
                    Console.WriteLine(customList.CountGreater(greaterElement));
                    break;
                case "Max":
                    Console.WriteLine(customList.Max());
                    break;
                case "Min":
                    Console.WriteLine(customList.Min());
                    break;
                case "Print":
                    Console.Write(customList);
                    break;
                case "Sort":
                    customList.Sort();
                    break;
            }
            input = Console.ReadLine().Split();
            command = input[0];
        }
    }
}