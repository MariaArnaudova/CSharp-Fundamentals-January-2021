using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that receives two characters and prints 
            // on a single line all the characters in between them according to ASCII.

            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            PrintLineCharectersBetweenTwoSigns(a, b);
        }
        static void PrintLineCharectersBetweenTwoSigns(char firstChar, char lastChar)
        {
            if (firstChar < lastChar)
            {
                for (int i = firstChar + 1; i < lastChar; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = lastChar + 1; i < firstChar; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
