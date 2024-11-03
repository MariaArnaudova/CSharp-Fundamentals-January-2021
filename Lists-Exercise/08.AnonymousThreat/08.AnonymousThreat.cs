using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
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
                        if (word.Length < partitions)
                        {
                            string newData = String.Empty;
                            for (int i = 0; i < data.Count; i++)
                            {
                                newData += data[i];                                
                            }
                            for (int i = data.Count-1; i>=0 ; i--)
                            {
                                data.Remove(data[i]);
                            }
                            data.Insert(0,newData);
                            break;
                        }

                        List<string> dividedWord = new List<string>();

                        int strigLengthToAdd = word.Length / partitions;

                        int startIndex = 0;
                        for (int i = 0; i < partitions; i++)
                        {

                            if (i == partitions - 1)
                            {
                                dividedWord.Add(word.Substring(startIndex, word.Length - startIndex));
                            }
                            else
                            {
                                dividedWord.Add(word.Substring(startIndex, strigLengthToAdd));
                                startIndex += strigLengthToAdd;
                            }
                        }

                        data.RemoveAt(index);
                        data.InsertRange(index, dividedWord);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ', data));
        }
    }
}
