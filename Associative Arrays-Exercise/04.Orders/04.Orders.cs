using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> priceProducts = new Dictionary<string, decimal>();
            Dictionary<string, int> quantityProducts = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "buy")
            {

                string[] productInfo = input.Split();

                string product = productInfo[0];
                decimal price = decimal.Parse(productInfo[1]);
                int quantity = int.Parse(productInfo[2]);

                if (priceProducts.ContainsKey(product))
                {
                    quantityProducts[product] += quantity;
                    priceProducts[product] = price;
                }
                else
                {
                    priceProducts.Add(product, price);
                    quantityProducts.Add(product, quantity);
                }

                input = Console.ReadLine();

            }

            foreach (var kvp in priceProducts)
            {

                string product = kvp.Key;
                decimal Price = kvp.Value;
                int quantityProduct = quantityProducts[product];

                decimal totalpriceProduct = quantityProduct * Price;

                Console.WriteLine($"{ product} -> { totalpriceProduct}");

            }
        }
    }
}
