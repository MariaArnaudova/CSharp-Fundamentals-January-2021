using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] operations = Console.ReadLine().Split();

            while (operations[0] != "End")
            {
                string operation = operations[0];
                if (operation == "Add")
                {
                    numbers.Add(int.Parse(operations[1]));
                }
                else if (operation == "Insert")
                {
                    int index = int.Parse(operations[2]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int num = int.Parse(operations[1]);
                        numbers.Insert(index, num);
                    }                   
                }
                else if (operation == "Remove")
                {
                    int index = int.Parse(operations[1]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }                  
                }
                else if (operation == "Shift")
                {
                    string leftRight = (operations[1]).ToString();
                    
                    if (leftRight == "left")
                    {
                        int count = int.Parse(operations[2]);
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Insert(numbers.Count, numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (leftRight == "right")
                    {
                        int count = int.Parse(operations[2]);
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }           
                operations = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
