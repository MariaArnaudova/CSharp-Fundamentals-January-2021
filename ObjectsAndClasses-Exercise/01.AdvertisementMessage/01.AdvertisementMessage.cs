using System;
using System.Collections.Generic;

namespace _01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] autors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int countMessages = int.Parse(Console.ReadLine());

            Random newrandom = new Random();

            List<string> message = new List<string>();

            for (int i = 0; i < countMessages; i++)
            {
                string phrase = phrases[newrandom.Next(0,phrases.Length-1)];
                string @event = events[newrandom.Next(0, phrases.Length - 1)];
                string autor = autors[newrandom.Next(0, phrases.Length - 1)];
                string city = cities[newrandom.Next(0, cities.Length - 1)];

                Console.WriteLine($"{phrase} {@event} {autor} – {city}");
            }
        }
    }
}
