using System;
using System.Linq;

namespace _03.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program which creates 2 arrays. You will be given an integer n. 
            // On the next n lines you get 2 integers. 
            // Form 2 arrays.

            int nLines = int.Parse(Console.ReadLine());

            int[] arr1 = new int[nLines];
            int[] arr2 = new int[nLines];

            for (int i = 0; i < nLines; i++)
            {
                int[] currLine = Console.ReadLine()
                    .Split().
                    Select(int.Parse).
                    ToArray();
                if (i % 2 == 0)
                {
                    arr1[i] = currLine[0];
                    arr2[i] = currLine[1];
                }
                else
                {
                    arr1[i] = currLine[1];
                    arr2[i] = currLine[0];
                }
            }
            Console.WriteLine(String.Join(" ",arr1));
            Console.WriteLine(String.Join(" ",arr2));

        }
    }
}
