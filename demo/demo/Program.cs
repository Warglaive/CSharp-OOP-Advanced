using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int sumOfDigits = 0;
            int number = i;
            while (number > 0)
            {
                sumOfDigits += number % 10;
                number = number / 10;
            }
            bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
            Console.WriteLine("{0} -> {1}", i, isSpecial);
        }
    }
}
