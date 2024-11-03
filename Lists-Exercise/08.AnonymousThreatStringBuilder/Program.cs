using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.AnonymousThreatStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
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

                    if (index >= 0 && index <= data.Count - 1)
                    {
                        string word = data[index];

                       StringBuilder  dividedWord = new StringBuilder();

                        int partLengthToAdd = word.Length / partitions;
                        int lastPartEnd = partLengthToAdd + word.Length % partitions;

                        int startIndex = 0;
                        for (int i = 0; i < partitions; i++)
                        {
                            string newWord = word.Substring(i * partLengthToAdd, partLengthToAdd);

                            if (i == partitions - 1)
                            {
                                newWord = word.Substring(i * partLengthToAdd, lastPartEnd);
                            }
                            else
                            {
                                newWord = word.Substring(i * partLengthToAdd, lastPartEnd);
     
                            }
                            dividedWord.Append(newWord);
                        }

                        data.RemoveAt(index);
                        data.InsertRange(index, dividedWord.ToString().Split());
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ', data));
        }
    }
}
