using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a list of integers. 
            // Then until you receive "end", you will receive different commands:
            // Add { number}: add a number to the end of the list.
            // Remove { number}: remove a number from the list.
            // RemoveAt { index}: remove a number at a given index.
            // Insert { number}  { index}: insert a number at a given index.

            // Note: All the indices will be valid!
            // When you receive the "end" command, print the final state of the list(separated by spaces).

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split();
                int number = int.Parse(tokens[1]);

                if (tokens[0] == "Add")
                {
                    numbers.Add(number);
                }
                else if (tokens[0] == "Remove")
                {
                    numbers.Remove(number);
                }
                else if (tokens[0] == "RemoveAt")
                {
                    numbers.RemoveAt(number);
                }
                else if (tokens[0] == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, number);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
