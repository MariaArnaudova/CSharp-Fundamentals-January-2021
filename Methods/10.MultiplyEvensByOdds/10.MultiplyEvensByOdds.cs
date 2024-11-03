using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            input = Math.Abs(input);
            int multiply = GetMultipleOfEvenAndOdds(input);
            Console.WriteLine(multiply);

        }
        static int GetMultipleOfEvenAndOdds(int numbers)
        {
           int multiply= GetSumOfEvenDigits(numbers) * GetSumOfOddDigits(numbers);
            return multiply;
        }

        static int GetSumOfEvenDigits(int input)
        {
            string number = input.ToString();
            int sumEven = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentDigit = int.Parse(number[i].ToString());
                if (currentDigit % 2==0)
                {
                    sumEven += currentDigit;
                }
            }
            return sumEven;
        }

        static int GetSumOfOddDigits(int input)
        {
            string number = input.ToString();
            int sumOdd = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentDigit = int.Parse(number[i].ToString());
                if (currentDigit % 2 != 0)
                {
                    sumOdd += currentDigit;
                }
            }
            return sumOdd;
        }
    }
}
