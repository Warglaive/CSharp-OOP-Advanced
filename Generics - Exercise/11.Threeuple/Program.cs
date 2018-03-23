using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine().Split();
        Console.WriteLine(new Threeuple<string, string, string>($"{input[0]} {input[1]}", input[2], input[3]));

        input = Console.ReadLine().Split();
        var drunkResult = !input[2].Equals("drunk") ? "False" : "True";
        Console.WriteLine(new Threeuple<string, int, bool>(input[0], int.Parse(input[1]), bool.Parse(drunkResult)));

        input = Console.ReadLine().Split();

        Console.WriteLine(new Threeuple<string, double, string>(input[0], double.Parse(input[1]), input[2]));
        //    for (int i = 0; i < 3; i++)
        //    {
        //        var input = Console.ReadLine().Split();

        //        object item1 = input[0];
        //        object item2;
        //        object item3;
        //        if (input.Length == 4)
        //        {
        //            item1 += " " + input[1];
        //            item2 = input[2];
        //            item3 = input.Last();
        //        }
        //        else
        //        {
        //            item2 = input[1];
        //            item3 = input.Last();
        //        }

        //        if (item3.ToString() == "drunk")
        //        {
        //            item3 = "True";
        //        }
        //        else if (item3.ToString() == "not")
        //        {
        //            item3 = "False";
        //        }
        //        //
        //        if (double.TryParse(item2.ToString(), out _))
        //        {
        //            var toDouble = 0d;
        //            if (item2.ToString().Contains("."))
        //            {
        //                toDouble = Convert.ToDouble(item2);
        //                Threeuple<object, object, object> tuple
        //                    = new Threeuple<object, object, object>(item1, item2, item3);

        //                Console.WriteLine($"{tuple.Item1} -> {toDouble:F1} -> {tuple.Item3}");
        //            }
        //            else
        //            {
        //                toDouble = Convert.ToDouble(item2);
        //                Threeuple<object, object, object> tuple
        //                    = new Threeuple<object, object, object>(item1, item2, item3);
        //                Console.WriteLine($"{tuple.Item1} -> {toDouble} -> {tuple.Item3}");
        //            }
        //        }
        //        else
        //        {
        //            Threeuple<object, object, object> tuple
        //                = new Threeuple<object, object, object>(item1, item2, item3);

        //            Console.WriteLine($"{tuple.Item1} -> {item2} -> {tuple.Item3}");
        //        }
        //
    }
    
}