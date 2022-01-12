using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program to find all the top integers in an array.
            // A top integer is an integer which is bigger than all the elements to its right.

            // 0  1  2  3  4  5
            int[] arr = Console.ReadLine() // 14 24 3 19 15 17
                .Split().
                Select(int.Parse).
                ToArray();
            bool isBigger = false;
            int topInteger = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currNumber = arr[i];

                if (currNumber == arr[arr.Length - 1])
                {
                    topInteger = currNumber;
                    isBigger = true;
                }
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currNumber > arr[j])
                    {
                        topInteger = currNumber;
                        isBigger = true;
                    }
                    else
                    {
                        topInteger = 0;
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger == true)
                {
                    Console.Write(topInteger + " ");
                }
            }

        }
    }
}
