using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read an array from the console and sum only the even numbers.

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumEvenNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEvenNum += numbers[i];
                }
            }
            Console.WriteLine(sumEvenNum);

        }
    }
}
