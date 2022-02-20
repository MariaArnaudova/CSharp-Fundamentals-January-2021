using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Until you receive “Start” you will be given different coins
            // You have to sum them
            //Your vending machine only works with 0.1, 0.2, 0.5, 1, and 2 coins
            // If someone tries to insert some other coins you have to display 
            // “Cannot accept {money}” and not add it to the total money
            // . On the next few lines until you receive “End” you will be given products to purchase
            // Your machine has however only “Nuts”, “Water”, “Crisps”, “Soda”, “Coke”. 
            // The prices are: 2.0, 0.7, 1.5, 0.8, 1.0 respectively


            string input = Console.ReadLine();
            double sumCoins = 0.0;
            double coinsInsert = sumCoins;

            while (input != "Start")
            {
                double coins = double.Parse(input);
                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                else 
                {
                    sumCoins += coins;
                    
                }
                
                input = Console.ReadLine();
            }
            string products = Console.ReadLine();
            double priceProducts = 0.0;
            //double spendMoney = 0.0;

            while (products != "End")
            {
                if (products == "Nuts")
                {
                    priceProducts = 2.0;
                }
                else if (products == "Water")
                {
                    priceProducts = 0.7;
                }
                else if (products == "Crisps")
                {
                    priceProducts = 1.5;
                }
                else if (products == "Soda")
                {
                    priceProducts = 0.8;
                }
                else if (products == "Coke")
                {
                    priceProducts = 1.0;
                }               
                else
                {
                    Console.WriteLine($"Invalid product");
                    products = Console.ReadLine();
                    continue;
                }
                
                if (sumCoins >= priceProducts)
                {
                    Console.WriteLine($"Purchased {products.ToLower()}");
                    //spendMoney += priceProducts; ne e viarno
                    sumCoins -= priceProducts;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                products = Console.ReadLine();
            }
            //double leftMoney = coinsInsert - spendMoney; ne e viarno
            Console.WriteLine($"Change: {sumCoins:F2}");
        }
    }
}
