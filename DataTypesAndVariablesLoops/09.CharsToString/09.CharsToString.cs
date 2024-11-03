using System;

namespace _09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            // reads 3 lines of input. On each line you get a single character.
            // Combine all the characters into one string and print it on the console.

            char firstChar = char.Parse(Console.ReadLine());
            char seconChar = char.Parse(Console.ReadLine());
            char fhirdChar = char.Parse(Console.ReadLine());

            Console.WriteLine($"{firstChar}{seconChar}{fhirdChar}");
        }
    }
}