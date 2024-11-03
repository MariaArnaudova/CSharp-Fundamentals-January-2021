using System;
using System.Collections.Generic;

namespace _04.OrdersByClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Product> products = new Dictionary<string, Product>();



            while (true)
            {
                string input = Console.ReadLine();

                if (input=="buy")
                {
                    break;
                }

                string[] productInfo = input.Split();

                string nameProduct = productInfo[0];

                double priceProduct = double.Parse(productInfo[1]);

                int quantity = int.Parse(productInfo[2]);

                Product product = new Product(priceProduct, quantity);

                if (!products.ContainsKey(nameProduct))
                {

                    products.Add(nameProduct, product );

                }
                else
                {

                    products[nameProduct].Price = priceProduct;
                    products[nameProduct].Quantity += quantity;

                }
            }

            foreach (var kvp in products)
            {
                string productName = kvp.Key;
                double totalPrice = kvp.Value.Price * kvp.Value.Quantity;

                Console.WriteLine($"{productName} -> {totalPrice :F2}");

            }
        }

        class Product
        {
            public string Name { get; set; }

            public double Price { get; set; }

            public int Quantity { get; set; }

            public Product(double price, int quantity)
            {
                this.Price = price;
                this.Quantity = quantity;
            }
        }
    }
}
