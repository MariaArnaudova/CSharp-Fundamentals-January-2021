using System;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read an array of strings (space separated values), 
            //  reverse it and print its elements:

            string[] array = Console.ReadLine().Split();
            string[] reverseArr = new string[array.Length];

            //for (int i = 0; i < array.Length/2; i++)
            //{
            //    reverseArr[i] = array[array.Length -1-i];
            //}

            //for (int j = 0; j < array.Length; j++)
            //{
            //    Console.Write(reverseArr[j] + " ");
            //}
            for (int i = 0; i < array.Length; i++)
            {
                string left = array[i];
                string right = array[array.Length - i - 1];
                array[array.Length - i - 1] = left;
                array[i] = right;
            }

            //for (int i = 0; i < array.Length; i++)
            //{
                Console.Write(String.Join(" ", array));
            //}

            
        }
    }
}
