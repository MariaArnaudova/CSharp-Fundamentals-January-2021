using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // You will receive in total 3 * n lines
            // Each three lines will hold information for a single keg
            // model of the keg,  radius of the keg, 
            // and lastly is the height of the keg.
            // π * r^2 * h.

            int numberLines = int.Parse(Console.ReadLine());
            double maxVolume = 0;
            string kegModelMaxVolume = "";
            for (int i = 0; i < numberLines; i++)
            {
                string kegModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (maxVolume < volume)
                {
                    maxVolume = volume;
                    kegModelMaxVolume = kegModel;
                }
            }
            Console.WriteLine(kegModelMaxVolume);

        }
    }
}
