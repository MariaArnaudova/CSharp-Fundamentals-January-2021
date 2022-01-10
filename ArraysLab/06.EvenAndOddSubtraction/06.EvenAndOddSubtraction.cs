using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that calculates the difference between 
            // the sum of the even and the sum of the odd numbers in an array.

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumEvenNumbres = 0;
            int sumOddNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumbers = numbers[i];
                if (currentNumbers % 2 == 0)
                {
                    sumEvenNumbres += currentNumbers;
                }
                else
                {
                    sumOddNumbers += currentNumbers;
                }
            }
            int differenceSums = sumEvenNumbres - sumOddNumbers;
            Console.WriteLine(differenceSums);
        }
    }
}
