using System;

namespace _07.WaterOverflow_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nTimesPour = int.Parse(Console.ReadLine());

            int tankCapacity = 255;
            int waterInTank = 0;
            int freeSpace = tankCapacity;
    
            bool isFullTank = false;

            for (int i = 0; i < nTimesPour; i++)
            {
                int quantitiesOfWater = int.Parse(Console.ReadLine());
                if (tankCapacity < quantitiesOfWater)
                {
                    Console.WriteLine("Insufficient capacity!");
                    //continue;
                }

                if (tankCapacity >= quantitiesOfWater)
                {
                    waterInTank += quantitiesOfWater;
                    tankCapacity -= quantitiesOfWater;
                }              
            }
            Console.WriteLine(waterInTank);
        }
    }
}
