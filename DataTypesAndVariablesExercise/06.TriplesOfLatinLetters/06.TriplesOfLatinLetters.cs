using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program to read an integer n and print all triples 
            // of the first n small Latin letters, ordered alphabetically:
            int nNumLetter = int.Parse(Console.ReadLine());

            for (int i = 0; i < nNumLetter; i++)
            {
                for (int j =0 ; j < nNumLetter; j++)
                {
                    for (int k = 0; k < nNumLetter; k++)
                    {
                        Console.WriteLine($"{(char)(97+i)}{(char)(97+j)}{(char)(97 +k)}");
                    }
                }
            }
        }
    }
}
