using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstWord = words[0];
            string secondWord = words[1];

           int sum =  SumCharacterMultiplier(firstWord, secondWord);

            Console.WriteLine(sum);
        }

        private static int SumCharacterMultiplier(string firstWord, string secondWord)
        {
            int sumResult = 0;

            string longestWord = "";
            string shortestWord = "";

            //int minLength = Math.Min(firstWord.Length, secondWord.Length);

            if (firstWord.Length > secondWord.Length)
            {
                longestWord = firstWord;
                shortestWord = secondWord;
            }
            else
            {
                longestWord = secondWord;
                shortestWord = firstWord;
            }

            for (int i = 0; i < shortestWord.Length; i++)
            {
                sumResult += shortestWord[i] * longestWord[i];
            }

            for (int i = shortestWord.Length; i < longestWord.Length; i++)
            {
                sumResult += longestWord[i];
            }

            return sumResult;
        }
    }
}
