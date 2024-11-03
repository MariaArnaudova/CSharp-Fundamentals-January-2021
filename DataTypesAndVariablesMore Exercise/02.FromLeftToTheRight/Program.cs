using System;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {

            //var max = Math.Max(Math.Max(firstNo, secondNo), thirdNo));


            int n = int.Parse(Console.ReadLine());
            string currentNumbers = Console.ReadLine();
            string numberLeft = String.Empty;
            string numberRight = String.Empty;
            int sumOfDigitsLeft = 0;
            int sumOfDigitsRight = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < currentNumbers.Length; j++)
                {
                    if (currentNumbers[j] != ' ')
                    {
                        numberLeft += currentNumbers[j];
                        int currentDigitLeft = int.Parse(currentNumbers[j].ToString());
                        sumOfDigitsLeft += currentDigitLeft;
                    }
                    else
                    {
                        if (currentNumbers[j] == ' ')
                        {
                            continue;
                        }
                        numberRight += currentNumbers[j];
                        int currentDigitRight = int.Parse(currentNumbers[j].ToString());
                        sumOfDigitsRight += currentDigitRight;
                    }
                }
                currentNumbers = Console.ReadLine();

                if (sumOfDigitsLeft > sumOfDigitsRight)
                {
                    Console.WriteLine(sumOfDigitsLeft);
                }
                else
                {
                    Console.WriteLine(sumOfDigitsRight);
                }
            }

        }

    }
}
