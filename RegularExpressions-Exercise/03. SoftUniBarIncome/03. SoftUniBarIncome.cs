using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%\.]*?<(?<product>[\w]+)>[^|$%\.]*?\|(?<count>\d+)\|[^|$%\.]*?(?<price>\d+\.*\d*)\$";

            string input = Console.ReadLine();

            double totalIncome = 0;

            while (input != "end of shift")
            {

                Match currentMatch = Regex.Match(input, pattern);

                if (!currentMatch.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string customerName = currentMatch.Groups["customer"].Value;
                string product = currentMatch.Groups["product"].Value;
                int count = int.Parse(currentMatch.Groups["count"].Value);
                double price = double.Parse(currentMatch.Groups["price"].Value);


                double totalPrice = price * count;
                totalIncome += totalPrice;

                Console.WriteLine($"{ customerName}: { product} - { totalPrice:f2}");

                input = Console.ReadLine();

            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
