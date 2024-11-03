using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            bool isChanged = false;
            while (input != "end")
            {              
                string[] tokens = input.Split();
                string token = tokens[0];

                if (tokens[0] == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.Add(number);
                    isChanged = true;
                }
                else if (tokens[0] == "Remove")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.Remove(number);
                    isChanged = true;
                }
                else if (tokens[0] == "RemoveAt")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.RemoveAt(number);
                    isChanged = true;
                }
                else if (tokens[0] == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, number);
                    isChanged = true;
                }

                if (tokens[0] == "Contains")
                {
                    List<int> copyInput = new List<int>(numbers);
                    int num = int.Parse(tokens[1]);
                    if (copyInput.Contains(num))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                if (tokens[0] == "PrintEven")
                {
                    List<int> copyInput = new List<int>(numbers);
                    copyInput.RemoveAll(i => i % 2 != 0);
                    Console.WriteLine(String.Join(" ", copyInput));
                }

                if (tokens[0] == "PrintOdd")
                {
                    List<int> copyInput = new List<int>(numbers);
                    copyInput.RemoveAll(i => (i % 2 == 0));
                    Console.WriteLine(String.Join(" ", copyInput));
                }
                if (tokens[0] == "GetSum")
                {
                    List<int> copyInput = new List<int>(numbers);
                    Console.WriteLine(copyInput.Sum());
                }
                if (tokens[0] == "Filter") // '<', '>', ">=", "<=".
                {
                    int num = int.Parse(tokens[2]);
                    if (tokens[1] == "<")
                    {
                        List<int> copyInput = new List<int>(numbers);
                        copyInput.RemoveAll(i => i >= num);
                        Console.WriteLine(String.Join(" ", copyInput));
                    }
                    else if (tokens[1] == ">")
                    {
                        List<int> copyInput = new List<int>(numbers);
                        copyInput.RemoveAll(i => i <= num);
                        Console.WriteLine(String.Join(" ", copyInput));
                    }
                    else if (tokens[1] == ">=")
                    {
                        List<int> copyInput = new List<int>(numbers);
                        copyInput.RemoveAll(i => i < num);
                        Console.WriteLine(String.Join(" ", copyInput));
                    }
                    else if (tokens[1] == "<=")
                    {
                        List<int> copyInput = new List<int>(numbers);
                        copyInput.RemoveAll(i => i > num);
                        Console.WriteLine(String.Join(" ", copyInput));
                    }
                }
                input = Console.ReadLine();
            }

            if (isChanged)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}
