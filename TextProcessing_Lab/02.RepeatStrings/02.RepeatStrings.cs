using System;
using System.Text;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            StringBuilder concatString = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                for (int j = 0; j < currentWord.Length; j++)
                {
                    concatString.Append(currentWord);
                }
            }

            string result = concatString.ToString();

            Console.WriteLine(String.Join(" ", result));

        }
    }
}
