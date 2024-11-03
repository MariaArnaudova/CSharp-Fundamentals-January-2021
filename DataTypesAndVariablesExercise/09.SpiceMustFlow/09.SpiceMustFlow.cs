using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int totalAmount = 0;
            int countDays = 0;

            while (startingYield >= 100)
            {
                totalAmount += startingYield;
                startingYield -= 10;
                countDays++;

                if (totalAmount - 26 < 0)
                {
                    totalAmount = 0;
                }
                else
                {
                    totalAmount -= 26;
                }              
            }
            if (totalAmount - 26 < 0)
            {
                totalAmount = 0;
            }
            else
            {
                totalAmount -= 26;
            }
            Console.WriteLine(countDays);
            Console.WriteLine(totalAmount);
        }
    }
}
