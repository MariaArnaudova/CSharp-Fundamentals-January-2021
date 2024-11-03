using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            List<int> peopleWagons = new List<int>(wagons);

            while (input != "end")
            {
                string[] typeInput = input.Split();

                if (typeInput[0] == "Add")
                {
                    int numPassengers = int.Parse(typeInput[1]);
                    peopleWagons.Add(numPassengers);
                }
                else
                {
                    int newPassengers = int.Parse(typeInput[0]);
                    for (int i = 0; i < peopleWagons.Count; i++)
                    {
                        int fitPassengers = peopleWagons[i] + newPassengers;

                        if (fitPassengers <= maxCapacity)
                        {
                            peopleWagons[i] += newPassengers;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", peopleWagons));
        }
    }
}
