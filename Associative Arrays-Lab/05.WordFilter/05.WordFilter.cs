using System;
using System.Linq;

namespace _05.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods = Console.ReadLine()
                .Split();

            string[] evenLengthFoods = foods
                .Where(f => f.Length % 2 == 0)
                .ToArray();

            //foreach (string food in evenLengthFoods)
            //{
            //    Console.WriteLine(food);
            //}

            Console.Write(String.Join(Environment.NewLine, evenLengthFoods));
        }
    }
}
