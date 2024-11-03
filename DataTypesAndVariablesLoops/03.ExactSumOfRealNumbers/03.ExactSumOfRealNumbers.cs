using System;

namespace _03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write program to enter n numbers and calculate and print their exact sum 
            // (without rounding)

            int nNumber = int.Parse(Console.ReadLine());
            decimal sumNumber = 0;
            

            for (int i = 0; i < nNumber; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sumNumber += number;           
            }
            Console.WriteLine($"{sumNumber}");
        }

    }
}
