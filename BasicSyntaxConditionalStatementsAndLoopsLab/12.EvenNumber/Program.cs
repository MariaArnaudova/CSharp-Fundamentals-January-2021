﻿using System;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (true)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine($"Please write an even number.");
                }
                else if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;

                }
                number = int.Parse(Console.ReadLine());
            }


        }
    }
}
