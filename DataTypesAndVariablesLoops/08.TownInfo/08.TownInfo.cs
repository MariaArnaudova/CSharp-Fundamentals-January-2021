﻿using System;

namespace _08.TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // You will be given 3 lines of input.
            // first line you will be given the name of the town
            // on the second – the population and 
            // on the third the area. 
            // Use the correct data types and print the result in the following format:

            string nameOfTown = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {nameOfTown} has population of {population}" +
                              $" and area {area} square km.");
        }
    }
}
