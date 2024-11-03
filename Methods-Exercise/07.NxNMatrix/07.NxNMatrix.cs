using System;

namespace _07.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that receives a single integer N
            // and prints NxN matrix with that number.

            int n = int.Parse(Console.ReadLine());
            PrintMatrixNxN(n);
        }
        static void PrintMatrixNxN(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
