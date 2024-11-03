using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            // >>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d+)\!(?<count>\d+)

            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)\!(?<quantity>\d+)";

            List<string> furniture = new List<string>();
            double totalPrice = 0;

            string input = Console.ReadLine();

            while (input != "Purchase")
            {

                Regex regex = new Regex(pattern);

                Match match = regex.Match(input);

                if (match.Success)
                {

                    furniture.Add(match.Groups["name"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    totalPrice += price * quantity;

                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            if (furniture.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, furniture));
            }

            Console.WriteLine($"Total money spend: {totalPrice:F2}");

            //Console.WriteLine("Bought furniture:");

            //foreach (var item in furniture)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
