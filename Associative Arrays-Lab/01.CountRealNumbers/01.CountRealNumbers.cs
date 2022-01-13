using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (int number in numbers)
            {

                if (counts.ContainsKey(number))
                {      
                    
                    counts[number] = counts[number] + 1;

                }
                else
                {
                    counts.Add(number, 1);
                }
            }

            foreach (KeyValuePair<double, int> number in counts)
            {
                Console.WriteLine($" {number.Key} -> {number.Value}");
            }
        }
    }
}
