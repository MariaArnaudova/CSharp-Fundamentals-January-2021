using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that sums all of the numbers in a list in the following order: 
            //  first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int numbersLength = numbers.Count;
            for (int i = 0; i < numbersLength / 2; i++)
            {
                int start = numbers[i];         // 1 2 3 4 5
                int end = numbers[numbers.Count - 1];
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
