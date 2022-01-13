using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWords = int.Parse(Console.ReadLine());

            var words = new Dictionary<string, List<string>>();
             //listSynonyms = new List<string>();

            for (int i = 0; i < countOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonyms = Console.ReadLine();

                if (words.ContainsKey(word))
                {
                    List<string> listSynonyms = words[word];
                    listSynonyms.Add(synonyms);
                }
                else
                {
                    words.Add(word, new List<string> { synonyms });
                }
            }

            foreach (var item in words)
            {
                string word = item.Key;
                List<string> synonyms = item.Value;

                Console.WriteLine($"{word} - {String.Join(", ", synonyms)}");

            }
        }
    }
}
