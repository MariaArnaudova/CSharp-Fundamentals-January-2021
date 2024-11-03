using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that calculates the total price of an order and prints it on the console. 
            // The method should receive one of the following products: 
            //coffee, coke, water, snacks; and a quantity of the product. 
            // The prices for a single piece of each product are:

            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculateTotalPrice(product, quantity);

        }

        static void CalculateTotalPrice(string product, int quantity)
        {
            double priceCoffee = 1.50;
            double water = 1.00;
            double coke = 1.40;
            double snacks = 2.00;

            double totalPrice = 0;

            if (product == "coffee")
            {
                totalPrice = priceCoffee * quantity;
            }
            else if (product == "water")
            {
                totalPrice = water * quantity;
            }
            else if (product == "coke")
            {
                totalPrice = coke * quantity;
            }
            else if (product == "snacks")
            {
                totalPrice = snacks * quantity;
            }
            Console.WriteLine($"{totalPrice:F2}");
        }

    }
}
