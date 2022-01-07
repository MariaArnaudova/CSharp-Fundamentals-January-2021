using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read an array of real numbers (space separated), 
            // round them in "away from 0" style and print the 
            // output as in the examples:

            string realNumbers = Console.ReadLine();
            //double[] separatedNumbers = new double[realNumbers.Length]Split().
            //                                      Select(double.Parse).ToArray();
            string[] separatedNumbers = realNumbers.Split();
            double[] numbers = new double[separatedNumbers.Length];
            int[] rounNumbers = new int[numbers.Length];

            for (int i = 0; i < rounNumbers.Length; i++)
            {
                numbers[i] = double.Parse(separatedNumbers[i]);
                rounNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);

            }

            for (int j = 0; j < rounNumbers.Length; j++)
            {
                Console.WriteLine($"{numbers[j]} => {rounNumbers[j]}");
                //Console.WriteLine("{0} => {1}", separatedNumbers[j], rounNumbers[j]);
            }


        }
    }
}
