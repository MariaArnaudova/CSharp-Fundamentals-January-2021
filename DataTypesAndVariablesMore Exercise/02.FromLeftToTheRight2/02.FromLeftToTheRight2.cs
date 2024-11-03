using System;
using System.Numerics;

namespace _02.FromLeftToTheRight2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            string numberLeft = String.Empty;
            string numberRight = String.Empty;
            byte sumOfDigitsLeft = 0;
            byte sumOfDigitsRight = 0;
            byte countDigits = 0;

            for (int i = 0; i < n; i++)
            {
                string currentNumbers = Console.ReadLine();
                for (int j = 0; j < currentNumbers.Length; j++)
                {
                    countDigits++;
                    char currentChar = currentNumbers[j];
                    if (currentChar == ' ')
                    {
                        break;
                    }

                    byte currentDigitLeft = byte.Parse(currentNumbers[j].ToString());
                    sumOfDigitsLeft += currentDigitLeft;
                    numberLeft += currentChar;
                }

                for (int k = countDigits; k < currentNumbers.Length; k++)
                {
                    char currentChar = currentNumbers[k];                  
                    if (currentChar == '-')
                    {
                        numberRight += currentChar;
                        continue;
                    }
                    numberRight += currentChar;
                    byte currentDigitRight = byte.Parse(currentNumbers[k].ToString());
                    sumOfDigitsRight += currentDigitRight;
                }
       
                if (long.Parse(numberLeft) > long.Parse(numberRight))
                {
                    Console.WriteLine(Math.Abs(sumOfDigitsLeft));   
                }
                else
                {
                    Console.WriteLine(Math.Abs(sumOfDigitsRight));       
                }
                numberLeft = "";
                numberRight = "";
                sumOfDigitsLeft = 0;
                sumOfDigitsRight = 0;
                countDigits = 0;
            }

        }
    }
}
