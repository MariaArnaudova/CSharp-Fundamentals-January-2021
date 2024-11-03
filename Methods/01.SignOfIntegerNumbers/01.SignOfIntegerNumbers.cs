using System;

namespace _01.SignOfIntegerNumbers
{
    class Program
    {

        static void PrintSignOfInteger(int number)
        {
            string print = "";
            if (number > 0)
            {
                print = "positive";
            }
            else if (number < 0)
            {
                print = "negative";
            }
            else
            {
                print = "zero";
            }
            Console.WriteLine($"The number {number} is {print}.");
        }

        static void Main(string[] args)
        {
            // Create a method that prints the sign of an integer number n:
            int n = int.Parse(Console.ReadLine());
            PrintSignOfInteger(n);

        }
    }
}
