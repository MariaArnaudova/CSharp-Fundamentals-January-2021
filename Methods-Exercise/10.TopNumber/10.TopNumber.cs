using System;
using System.Linq;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
       {
             //A top number is an integer that holds the following properties:
             //  •	Its sum of digits is divisible by 8, e.g. 8, 16, 88.
             //  •   Holds at least one odd digit, e.g. 232, 707, 87578.
             //Write a program to print all master numbers in the range[1…n].

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i<number; i++)
            {
                int currentNumber = i;
                if ((SumDigitsDovisibleToEight (currentNumber) 
                    &&FindOddDigit(currentNumber))==true)
                {
                    Console.WriteLine(currentNumber);
                }
                else
                {
                    continue;
                }
            }        
        }
        static bool SumDigitsDovisibleToEight(int input)
        {
            int num = input;
            int sumDigits = 0;
            bool isDivisible = false;
            while (num > 0)
            {
                int currDigit = num % 10;
                sumDigits += currDigit;              
                num = num / 10;
            }
            if (sumDigits % 8 == 0)
            {
                isDivisible = true;
            }
            return isDivisible;
        }
        static bool FindOddDigit(int input)
        {
            int num = input;
            bool isOdd = false;
            while (num > 0)
            {
                int currDigit = num % 10;
                if (currDigit % 2 == 1)
                {
                    isOdd = true;
                    break;
                }
                num = num / 10;
            }
            return isOdd;
        }
    }
}

