using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonimousThreat_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
              .Split(/*new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries*/)
              .ToList();

            string input = Console.ReadLine();
            List<string> result = new List<string>();

            while (input != "3:1")
            {
                string[] commandEllements = input.Split();
                string command = commandEllements[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(commandEllements[1]);
                    int endIndex = int.Parse(commandEllements[2]);

                    string newData = String.Empty;

                    if (startIndex < 0)
                    {
                        if (endIndex >= 0 && endIndex <= data.Count - 1)
                        {
                            startIndex = 0;
                        }
                    }
                    if (endIndex > data.Count - 1)
                    {
                        if (startIndex >= 0 && startIndex <= data.Count - 1)
                        {
                            endIndex = data.Count - 1;
                        }
                    }

                    if ((startIndex >= 0 && startIndex <= data.Count - 1)
                        && (endIndex >= 0 && endIndex <= data.Count - 1))
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            newData += data[i];
                        }
                        data.RemoveRange(startIndex, endIndex - startIndex + 1);
                        data.Insert(startIndex, newData);
                    }
                }
                else if (command == "divide")
                {
                    int index = int.Parse(commandEllements[1]);
                    int partitions = int.Parse(commandEllements[2]);

                    string word = data[index];
                    
                    List<string> dividedWord = new List<string>();

                   int partLengthToAdd = word.Length / partitions;
                   int lastPartEnd = partLengthToAdd + word.Length % partitions;

                    for (int i = 0; i < partitions; i++)
                    {
                        string newWord = word.Substring(i * partLengthToAdd, partLengthToAdd);

                        if (i == partitions - 1)
                        {
                            newWord = word.Substring(i * partLengthToAdd, lastPartEnd);
                        }
                        dividedWord.Add(newWord);
                    }
                    data.RemoveAt(index);
                    data.InsertRange(index, dividedWord);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ', data));
        }
    }
}
