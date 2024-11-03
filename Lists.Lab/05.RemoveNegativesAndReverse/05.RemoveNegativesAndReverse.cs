using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order.
            // In case there are no elements left in the list, print "empty".

            List<int> integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();

            bool isNegativeList = true;

            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] >= 0)
                {
                    result.Add(integers[i]);
                    isNegativeList = false;
                }
            }
            if (isNegativeList == true)      // result == 0
            {
                Console.WriteLine("empty");
            }
            result.Reverse();
            Console.WriteLine(String.Join(" ", result));


            //for (int i = 0; i < integers.Count; i++)
            //{
            //    if (integers[i] < 0)
            //    {
            //        integers.Remove(integers[i]);
            //        i = -1;
            //    }
            //}

            //if (integers.Count == 0)
            //{
            //    Console.WriteLine("empty");
            //}
            //integers.Reverse();
            //Console.WriteLine(String.Join(" ", integers));

            // ! can also be used: RemoveAll()

            //for (int i = 0; i < integers.Count; i++)
            //{
            //    if (integers[i] >= 0)
            //    {
            //        integers.RemoveAll(i => i < 0);
            //    }
            //}
            //if (integers.Count == 0)
            //{
            //    Console.WriteLine("empty");
            //}
            //integers.Reverse();
            //Console.WriteLine(String.Join(" ", integers));
        }
    }
}
