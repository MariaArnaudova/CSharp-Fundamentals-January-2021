using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            // On the first line, you will receive n – the number of lines, which will follow
            //  On the next n lines – you receive quantities of water, which you have to pour in the tank
            // You have a water tank with capacity of 255 liters

            int nTimesPour = int.Parse(Console.ReadLine());

            int tankCapacity = 0;

            bool isFullTank = false;

            for (int i = 0; i < nTimesPour; i++)
            {
                int quantitiesOfWater = int.Parse(Console.ReadLine());

                if (tankCapacity + quantitiesOfWater > 255)
                {
                    Console.WriteLine("Insufficient capacity!");                
                }
                else
                {
                    tankCapacity += quantitiesOfWater;
                }              
            }
            Console.WriteLine(tankCapacity);
        }
    }
}
