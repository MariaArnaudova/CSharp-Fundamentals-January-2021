using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> countTechology = new Dictionary<string, List<string>>();
            Dictionary<string, List<int>> submitionsPerUser = new Dictionary<string, List<int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                string[] dataExam = input.Split("-");

                string nameUser = dataExam[0];
                string tehnology = dataExam[1];
               
                if (tehnology == "banned")
                {
 
                    if (submitionsPerUser.ContainsKey(nameUser))
                    {
                        submitionsPerUser.Remove(nameUser);
                        continue;
                    }
                }

                int scores = int.Parse(dataExam[2]);

                if (!countTechology.ContainsKey(tehnology))
                {
                    countTechology.Add(tehnology, new List<string>());
                    submitionsPerUser.Add(nameUser, new List<int>());
                }
                else
                {
                    countTechology[tehnology].Add(nameUser);
                }              

                if (!submitionsPerUser.ContainsKey(nameUser))
                {
                    submitionsPerUser.Add(nameUser, new List<int>());
                    submitionsPerUser[nameUser].Add(scores);
                }
                else
                {
                    submitionsPerUser[nameUser].Add(scores);
                }
            }

            Console.WriteLine("Results:");

            var orderedSubmitions = submitionsPerUser
                   .OrderByDescending(x => x.Value.Max())
                   .ThenBy(x => x.Key)
                   .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in orderedSubmitions)
            {
                Console.WriteLine($"{kvp.Key} | {(kvp.Value).Max()}");
            }

            Console.WriteLine("Submissions:");

            var orderTechnology = countTechology
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key);

            foreach (var kvp in orderTechnology)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value.Count}");
            }
        }
    }
}
