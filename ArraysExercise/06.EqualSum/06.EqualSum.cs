using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // sum of the elements on its left is equal to the sum 
            // of the elements on its right
            // no elements to the left / right, their sum is considered to be 0.
            // Print the index  or "no" if there is no such index.

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int index = 0;
            bool haveSum = false;

            for (int current = 0; current < array.Length; current++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int left = 0; left < current; left++)
                {
                    leftSum += array[left];
                }
                for (int right = current + 1; right < array.Length; right++)
                {
                    rightSum += array[right];
                }

                if (rightSum == leftSum)
                {
                    haveSum = true;
                    index = current;
                }
            }

            if (haveSum)
            {           
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
