using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 British Pound = 1.31 Dollars

            decimal britishPound = decimal.Parse(Console.ReadLine());
            decimal dolars = britishPound * 1.31M;

            Console.WriteLine($"{dolars:f3}");
        }
    }
}
