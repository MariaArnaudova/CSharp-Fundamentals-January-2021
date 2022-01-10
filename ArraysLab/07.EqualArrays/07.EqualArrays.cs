using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // two arrays 
            // Arrays are identical if their elements are equal
            // If the arrays are identical find the sum of the first one 
            // print on the console whether they are identical or not
            //  "Arrays are identical. Sum: {sum}"
            // otherwise find the first index where the arrays differ and print on the console following message: 
            // "Arrays are not identical. Found difference at {index} index".

            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumArray = 0;
            int firstDifferentIndex = 0;
            bool isEquals = false;

            for (int i = 0; i < firstArray.Length; i++)
            {
                int currentFirstArray = firstArray[i];
                int currentSecondArray = secondArray[i];

                if (currentFirstArray == currentSecondArray)
                {
                    sumArray += currentFirstArray;
                    isEquals = true;                 
                }
                else
                {
                    firstDifferentIndex = i;
                    isEquals = false;
                    break;
                }
            }

            if (isEquals)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumArray}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {firstDifferentIndex} index");
            }
            //if (!isEquals)
            //{
            //    Console.WriteLine($"Arrays are not identical. Found difference at {firstDifferentIndex} index");
            //}
            //else
            //{
            //    Console.WriteLine($"Arrays are identical. Sum: {sumArray}");

            //}

        }
    }
}
