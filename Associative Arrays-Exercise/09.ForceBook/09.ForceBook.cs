using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sidesAndUsers = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains(" | "))
                {
                    string[] information = input.Split(" | ");

                    string side = information[0];
                    string user = information[1];

                    bool existUSer = false;

                    foreach (var kvp in sidesAndUsers)
                    {
                        if (kvp.Value.Contains(user))
                        {
                            existUSer = true;
                            break;
                        }
                    }

                    if (existUSer)
                    {
                        continue;
                    }

                    if (!sidesAndUsers.ContainsKey(side))
                    {

                        sidesAndUsers.Add(side, new List<string>());
                        sidesAndUsers[side].Add(user);

                    }
                    else
                    {

                        if (!sidesAndUsers[side].Contains(user))
                        {
                            sidesAndUsers[side].Add(user);
                        }
                    }
                }
                else if (input.Contains(" -> "))
                {
                    string[] information = input.Split(" -> ");

                    string user = information[0];
                    string side = information[1];

                    //string currentSide = "";
                    bool isRemoved = false;

                    foreach (var item in sidesAndUsers)
                    {
                        if (item.Value.Contains(user))
                        {
                            //currentSide = item.Key;
                            item.Value.Remove(user);
                            isRemoved = true;
                        }
                        if (isRemoved)
                        {
                            break;
                        }
                    }

                    if (!sidesAndUsers.ContainsKey(side))
                    {
                        sidesAndUsers.Add(side, new List<string> { user });

                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        sidesAndUsers[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
            }

            var orderSIdes = sidesAndUsers
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in orderSIdes)
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");

                //List<string> members = item.Value; // Вариант за сортировка.
                //members.Sort();

                foreach (string member in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {member}");
                }
            }
        }
    }
}
