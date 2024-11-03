using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            Dictionary<char, int> countChars = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string currWord = words[i];

                foreach (char currChar in currWord)
                {
                    if (!countChars.ContainsKey(currChar))
                    {
                        countChars.Add(currChar, 1);
                    }
                    else
                    {
                        countChars[currChar]++;
                    }
                }
            }

            foreach (var currChar in countChars)
            {
                Console.WriteLine($"{currChar.Key} -> {currChar.Value}");
            }
        }
    }
}
