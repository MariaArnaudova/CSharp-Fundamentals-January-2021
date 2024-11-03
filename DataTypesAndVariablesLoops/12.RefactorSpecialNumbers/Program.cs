using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int number = 0;
            for (int currentNumber = 1; currentNumber <= inputNumber; currentNumber++)
            {
                number = currentNumber;
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                bool isSum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNumber, isSum);

            }
        }
    }
}
