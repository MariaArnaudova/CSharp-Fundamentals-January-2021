using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5! = 5*4*3*2*1 = 120
            // 10! = 10*9*8*7*...*2*1 = 3628800

            int number = int.Parse(Console.ReadLine());
            int inputNumber = number;

            int currentNumber = 0;
            int factorielSum = 0;

            while (inputNumber != 0)
            {
                currentNumber = inputNumber % 10;
                inputNumber = inputNumber / 10;

                int factoriel = 1;

                for (int i = 1; i <= currentNumber; i++)
                {
                    factoriel *= i;            
                }
                factorielSum += factoriel;
            }
            string output = "";

            if (factorielSum == number)
            {
                output = "yes";
            }
            else
            {
                output = "no";
            }
            Console.WriteLine($"{output}");
        }

    }
}

