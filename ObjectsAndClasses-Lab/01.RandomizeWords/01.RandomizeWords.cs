using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ").ToList();

            Random randomWords = new Random();

            for (int i = 0; i < input.Count; i++)
            {
                int randomIndex = randomWords.Next(0,input.Count);

                string currRandomWord = input[randomIndex];
                string currWord = input[i];
                input[randomIndex] = currWord;
                input[i] = currRandomWord;
            }

            foreach (string word in  input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
