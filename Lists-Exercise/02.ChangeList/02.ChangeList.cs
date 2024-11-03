using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                if (commands[0] == "Delete")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        int currElement = int.Parse(commands[1]);
                        if (currElement == input[i])
                        {
                            input.Remove(input[i]);    // input.RemoveAll(i => i==currElement); 
                        }
                    }
                }
                else if (commands[0] == "Insert")
                {
                    int element = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);
                    input.Insert(position, element);
                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
