using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read two integer numbers. 
            // Calculate factorial of each number. 
            // Divide the first result by the second 
            //and print the division formatted to the second decimal point.

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            decimal divisionFactorials = CalculateFactorial(firstNumber)
                / CalculateFactorial(secondNumber);
            Console.WriteLine($"{divisionFactorials:F2}");
        }

        static decimal CalculateFactorial(int n)
        {
            decimal result = 1;          
            if (n == 0)
            {
                result = 1;
            }
            for (int i = 1; i <=n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
