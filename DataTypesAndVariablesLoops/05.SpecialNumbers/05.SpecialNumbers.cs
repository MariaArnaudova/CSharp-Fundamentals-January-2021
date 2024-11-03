using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // A number is special when its sum of digits is 5, 7 or 11.
            // read an integer n 
            // for all numbers in the range 1…n to print 
            // the number and if it is special or not (True / False).

            // Hints
            // To calculate the sum of digits of given number num, 
            // you might repeat the following: sum the last digit(num % 10) 
            // and remove it(sum = sum / 10) until num reaches 0.

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumDigit = 0;
                int currentNumber = i;

                while (currentNumber > 0)
                {
                    sumDigit += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }
                bool isSpecial = false;
                if (sumDigit == 5 || sumDigit == 7 || sumDigit == 11)
                {
                    isSpecial = true;
                    Console.WriteLine($"{i} -> {isSpecial}");
                }
                else
                {
                    Console.WriteLine($"{i} -> {isSpecial}");
                }
            }
        }
    }
}
