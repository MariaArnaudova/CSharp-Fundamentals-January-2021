using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> messages = Console.ReadLine().Split().ToList();
                string name = messages[0];
                

                if (messages[2] == "going!")
                {
                 
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else
                {
                    if (guests.Contains(name))
                    {                      
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }                   
                }
            }
            Console.Write(String.Join(Environment.NewLine, guests));
        }
    }
}
