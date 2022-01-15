using System;
using System.Collections.Generic;

namespace _05._SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> plateNumberUsers = new Dictionary<string, string>();

            int numberUsers = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberUsers; i++)
            {

                string[] currentUser = Console.ReadLine().Split();

                string stateUser = currentUser[0];
                string name = currentUser[1];

                if (stateUser == "register")
                {
                    string licensePlateNumber = currentUser[2];

                    if (!plateNumberUsers.ContainsKey(name))
                    {
                        plateNumberUsers.Add(name, licensePlateNumber);
                        Console.WriteLine($"{ name} registered { licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }

                }
                else if (stateUser == "unregister")
                {

                    if (!plateNumberUsers.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        plateNumberUsers.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }

                }
            }

            foreach (var kvpUser in plateNumberUsers)
            {
                string userName = kvpUser.Key;
                string licensePlateNumber = kvpUser.Value;

                Console.WriteLine($"{userName} => { licensePlateNumber}");
            }
        }
    }
}
