using System;

namespace _10.LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints whether a given character 
            // is upper-case or lower case.
            char letter = char.Parse(Console.ReadLine());
            
            if (65 <= (int)letter && (int)letter <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
