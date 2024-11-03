using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceMeters = int.Parse(Console.ReadLine());

            float distanceKilometers = distanceMeters * 0.001F;
            Console.WriteLine($"{distanceKilometers:F2}");

        }
    }
}
