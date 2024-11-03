using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int singleInteger = int.Parse(Console.ReadLine());
            int sumDiigit = 0;
            int currentNum = singleInteger;

            while (currentNum > 0)
            {
                int lastNum = currentNum % 10;
                currentNum = currentNum / 10;
                sumDiigit += lastNum;
            }
            Console.WriteLine($"{sumDiigit}");
        }
    }
}
