using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split("|",StringSplitOptions.RemoveEmptyEntries).ToList();

            input.Reverse();

            List<string> result = new List<string>();

            foreach (string item in input)
            {
                string[] numbers = item.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                foreach (string numbersToAdd in numbers)
                {
                    result.Add(numbersToAdd);
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
