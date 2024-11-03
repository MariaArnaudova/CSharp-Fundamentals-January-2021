using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> companies =new  Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input!="End")
            {

                string[] tokens = input.Split(" -> ");

                string company = tokens[0];
                string employee = tokens[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                    companies[company].Add(employee);
                }
                else
                {
                    if (!companies[company].Contains(employee))
                    {
                        companies[company].Add(employee);
                    }
                }

                input = Console.ReadLine();

            }

            var orderCompanies = companies
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in orderCompanies)
            {
                string company = kvp.Key;
                List<string> employee = kvp.Value;

                Console.WriteLine($"{company}");

                foreach (var item in employee)
                {
                    
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
