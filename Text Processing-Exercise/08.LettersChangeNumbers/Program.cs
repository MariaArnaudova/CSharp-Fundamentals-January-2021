using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] sequence = Console.ReadLine()
                .Split(new char[]{ ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);

            double firtsOperation = 0;
            double totalSum = 0;

            for (int i = 0; i < sequence.Length; i++)
            {

                string currentSequence = sequence[i];

                double number = double.Parse(currentSequence.Substring(1, currentSequence.Length - 2));

                char firstLetter = currentSequence[0];

                char secondLetter = currentSequence[currentSequence.Length - 1];


                string lowerFirstLetter = firstLetter.ToString().ToLower();
                double positionFirstLetter = char.Parse(lowerFirstLetter) - 96;

                string lowerSecondLetter = secondLetter.ToString().ToLower();
                double positionSecondLetter = char.Parse(lowerSecondLetter) - 96;

                if (firstLetter > 64 && firstLetter < 91)
                {

                    firtsOperation = number / positionFirstLetter;


                }
                else
                {

                    firtsOperation = number * positionFirstLetter;

                }

                double lastOperations = 0;

                if (secondLetter > 64 && secondLetter < 91)
                {

                    lastOperations = firtsOperation - positionSecondLetter;

                }
                else
                {

                    lastOperations = firtsOperation + positionSecondLetter;

                }

                totalSum += lastOperations;

            }

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
