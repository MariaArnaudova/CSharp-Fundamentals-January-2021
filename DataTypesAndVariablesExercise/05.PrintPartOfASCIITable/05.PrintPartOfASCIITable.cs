using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            // prints part of the ASCII table 
            // first line -the char index you should start with 
            // second line - the index of the last character

            int firsChar = int.Parse(Console.ReadLine());
            int lastChar = int.Parse(Console.ReadLine());
            for (int i = firsChar; i <= lastChar; i++)
            {
                char currentChar = (char)i;
                Console.Write($"{currentChar} ");
            }
        }
    }
}
