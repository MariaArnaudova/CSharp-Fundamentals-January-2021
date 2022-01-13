using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> orderedNumbers = numbers
                .OrderByDescending(x => x)
                .ToList();

            if (orderedNumbers.Count > 3)
            {
                int length = 3;

                for (int i = 0; i < length; i++)
                {

                    Console.Write($"{orderedNumbers[i] + " "}");

                    if (orderedNumbers[i] == orderedNumbers[orderedNumbers.Count - 1])
                    {
                        Console.WriteLine($"{orderedNumbers[orderedNumbers.Count - 1]}");
                    }
                }

            }
            else
            {
                Console.WriteLine(String.Join(" ", orderedNumbers));
            }


           // orderedNumbers = numbers
           //.OrderByDescending(x => x)
           //.Take(3)
           //.ToList();

           // int count = orderedNumbers.Count >= 3 ? 3 : orderedNumbers.Count;

           // for (int i = 0; i < count; i++)
           // {
           //     Console.Write($"{orderedNumbers[i]}");
           // }
        }
    }
}
