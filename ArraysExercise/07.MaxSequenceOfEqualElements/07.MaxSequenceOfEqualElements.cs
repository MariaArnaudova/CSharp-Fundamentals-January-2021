using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the longest sequence of equal elements 
            // in an array of integers. 
            // If several longest sequences exist, print the leftmost one.

            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
 
            int currCount = 1;
            int bestCount = 0;
            int bestElement = 0;

            for (int j = 0; j < array.Length - 1; j++)
            {
                int currElement = array[j];
                if (currElement == array[j+1])
                {
                    currCount++;
                }
                else
                {
                    currCount = 1;
                    continue;
                }
                if (currCount > bestCount)
                {
                    bestCount = currCount;
                    bestElement = currElement;
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(bestElement + " ");
            }

        }
    }
}
