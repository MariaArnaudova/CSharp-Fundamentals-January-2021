using System;

namespace _08.TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which receives a number – n, 
            //and prints a triangle from 1 to n as in the examples.

            int nNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nNumber; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
