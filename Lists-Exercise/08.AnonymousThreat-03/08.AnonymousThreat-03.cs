using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.AnonymousThreat_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .ToList();

            List<string> result = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "3:1")
                {
                    break;
                }
                string[] commandEllements = input
                    .Split();
                string command = commandEllements[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(commandEllements[1]);
                    int endIndex = int.Parse(commandEllements[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (startIndex > data.Count - 1 || endIndex < 0)
                    {
                        continue;
                    }
                    if (endIndex > data.Count - 1)
                    {
                        endIndex = data.Count - 1;
                    }
                    Merge(data, startIndex, endIndex);
                }
                else
                {
                    int index = int.Parse(commandEllements[1]);
                    int parts = int.Parse(commandEllements[2]);

                    string element = data[index];
                    data.RemoveAt(index);

                    List<string> newWord = Divide(element, parts);
                    data.InsertRange(index, newWord);
                }
            }
            Console.WriteLine(String.Join(' ', data));
        }

        private static List<string> Divide(string element, int parts)
        {
            List<string> dividedWord = new List<string>();
            int parthLength = element.Length / parts;
            int lastparthLength = element.Length / parts - element.Length % parts;
            for (int i = 0; i < parts; i++)
            {
                string newWord = element.Substring(i * parthLength, parthLength);
                if (i == parts - 1)
                {
                    newWord = element.Substring(i * parthLength, parthLength);
                }
                dividedWord.Add(newWord);
            }
            return dividedWord;

        }

        private static void Merge(List<string> data, int startIndex, int endIndex)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                string word = data[i];
                sb.Append(word);
            }
            data.RemoveRange(startIndex, endIndex - startIndex + 1);
            data.Insert(startIndex, sb.ToString());

        }
    }
}
