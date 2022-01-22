using System;

namespace _03.Vacantion100
{
    class Program
    {
        static void Main(string[] args)
        {
            //	          Friday  Saturday	Sunday
            //  Students    8.45    9.80    10.46
            //  Business    10.90   15.60   16
            //  Regular      15      20     22.50

            int numberPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0.0;
            double priceWithDiscount = 0.0;

            if (typeGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 10.46;
                }
                price = price * numberPeople;

                if (numberPeople < 30)
                {
                    Console.WriteLine($"Total price: {price:F2}");
                }
                else if (numberPeople >= 30)
                {
                    priceWithDiscount = price - price * 0.15;
                    Console.WriteLine($"Total price: {priceWithDiscount:F2}");
                }
            }
            else if (typeGroup == "Business") // 10.90   15.60   16
            {

                if (dayOfWeek == "Friday")
                {
                    price = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 16;
                }
                if (numberPeople < 100)
                {
                    price = price * numberPeople;
                    Console.WriteLine($"Total price: {price:F2}");
                }
                else if (numberPeople >= 100)
                {
                    numberPeople -= 10;
                    price = price * numberPeople;
                    Console.WriteLine($"Total price: {price:F2}");
                }
            }
            else if (typeGroup == "Regular") // 15      20     22.50
            {
                if (dayOfWeek == "Friday")
                {
                    price = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 22.50;
                }
                price = price * numberPeople;
                if (numberPeople >= 10 && numberPeople <= 20)
                {
                    priceWithDiscount = price - price * 0.05;
                    Console.WriteLine($"Total price: {priceWithDiscount:F2}");
                }
                else
                {
                    Console.WriteLine($"Total price: {price:F2}");
                }
            }
        }
    }
}