using System;
using System.Linq;

namespace _08.CondenseArrayMy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[numbers.Length];

            while (numbers.Length != 1)
            {
                int[] newArr = new int[numbers.Length - 1];

                for (int i = 0; i < newArr.Length; i++)
                {
                    newArr[i] = numbers[i] + numbers[i + 1];
                    //Console.Write(String.Join(" ", newArr[i]));
                    //Console.WriteLine();
                }
                numbers = newArr;
            }
            Console.Write(String.Join(" ",numbers));
        }
    }
}
