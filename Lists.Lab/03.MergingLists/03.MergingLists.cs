using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondLine = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            List<int> mergeLines = new List<int>();
            int countMaxList = Math.Max(firstLine.Count, secondLine.Count);

            for (int i = 0; i < countMaxList; i++)
            {
                if (i < firstLine.Count)
                {
                    mergeLines.Add(firstLine[i]);
                }

                if (i < secondLine.Count)
                {
                    mergeLines.Add(secondLine[i]);
                }
            }

            Console.WriteLine(String.Join(" ", mergeLines));
        }
    }
}
