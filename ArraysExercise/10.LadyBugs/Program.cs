using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. integer - the size of the field
            // 2. initial indexes of all ladybugs separated by a blank space. 
            //    The given indexes may or may not be inside the field range
            // 3. until you get the "end" command you will receive commands in the format: 
            //    "{ladybug index} {direction} {fly length}"


            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialIndex = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string commands = Console.ReadLine();/*.Split();*/
            string[] inputCommands = new string(commands)
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            //Console.WriteLine(String.Join(" ", inputCommands));

            int[] field = new int[fieldSize];

            int fullCell = 1;
            for (int i = 0; i < initialIndex.Length; i++)
            {
                field[i] = fullCell;
            }

            while (true)
            {
                if (commands == "end")
                {
                    break;
                }
                int bugsIndex = int.Parse(inputCommands[0]);
                string direction = inputCommands[1];
                int flyLength = int.Parse(inputCommands[2]);

                if (direction == "right")
                {
                    //for (int i = 0; i < field.Length; i++)
                    //{
                    if (field[bugsIndex] == 0 || bugsIndex >= field.Length)
                    {
                        break;
                    }

                    if (field[bugsIndex] == fullCell)
                    {
                        field[bugsIndex]--;
                    }

                    //if (field[bugsIndex + 1] == 0)
                    //{
                    //    field[bugsIndex + 1]++;
                    //}
                    //else
                    //{
                    //    if (bugsIndex-3 >= field.Length)
                    //    {
                    //        break;
                    //    }
                    //    else
                    //    {
                    for (int j = bugsIndex + 1; bugsIndex < field.Length; bugsIndex++)
                    {
                        if (field[j] == 0)
                        {
                            field[j]++;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    //    }
                    //}
                    //}
                }
                commands = Console.ReadLine();
                inputCommands = new string(commands)
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
            Console.WriteLine(String.Join(" ", field));
        }
    }
}
