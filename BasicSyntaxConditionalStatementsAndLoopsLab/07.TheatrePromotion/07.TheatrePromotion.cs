using System;

namespace _07.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (0 <= age && age <= 18)
            {
                if (typeOfDay == "Weekday")
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
                else if (typeOfDay == "Weekend")
                {
                    price = 15;
                    Console.WriteLine($"{price}$");
                }
                else if (typeOfDay == "Holiday")
                {
                    price = 5;
                    Console.WriteLine($"{price}$");
                }
            }
            else if (18 < age && age <= 64)
            {
                if (typeOfDay == "Weekday")
                {
                    price = 18;
                    Console.WriteLine($"{price}$");
                }
                else if (typeOfDay == "Weekend")
                {
                    price = 20;
                    Console.WriteLine($"{price}$");
                }
                else if (typeOfDay == "Holiday")
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
            }
            else if (64 < age && age <= 122)
            {
                if (typeOfDay == "Weekday")
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
                else if (typeOfDay == "Weekend")
                {
                    price = 15;
                    Console.WriteLine($"{price}$");
                }
                else if (typeOfDay == "Holiday")
                {
                    price = 10;
                    Console.WriteLine($"{price}$"));
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
