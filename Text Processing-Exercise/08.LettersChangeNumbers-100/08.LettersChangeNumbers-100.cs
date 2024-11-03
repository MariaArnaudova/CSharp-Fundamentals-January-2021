using System;

namespace _08.LettersChangeNumbers_100
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] sequence = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;

            for (int i = 0; i < sequence.Length; i++)
            {

                string currentSequence = sequence[i];

                char firstLetter = currentSequence[0];

                char secondLetter = currentSequence[currentSequence.Length - 1];

                double number = double.Parse(currentSequence.Substring(1, currentSequence.Length - 2));

                if (char.IsUpper(firstLetter))
                {

                    number /= firstLetter - 64;

                }
                else
                {

                    number *= firstLetter - 96;

                }

                if (char.IsUpper(secondLetter))
                {

                    number -= secondLetter - 64;

                }
                else
                {

                    number += secondLetter - 96;

                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
