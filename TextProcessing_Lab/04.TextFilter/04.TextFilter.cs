using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var bannWord in bannedWords)
            {

                if (text.Contains(bannWord))
                {
                    text = text.Replace(bannWord, new string('*', bannWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
