using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that calculates and returns the value 
            // of a number raised to a given power:
            double number = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            double powNumber = CalculatePowNumber(number, pow);
            Console.WriteLine(powNumber);
        }
        static double CalculatePowNumber(double number, int pow)
        {
            double powNumber = 1;
            for (int i = 0; i < pow; i++)
            {
                powNumber *= number;
            }
            return powNumber;
        }
    }
}
