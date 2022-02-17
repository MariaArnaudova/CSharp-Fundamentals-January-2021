using System;

namespace _09.SumfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddCount = int.Parse(Console.ReadLine());
            int sumNumbers = 0;
            int oddnum = 1;
            for (int i = 1; i <= oddCount; i++)
            {   
                Console.WriteLine(oddnum);
                sumNumbers += oddnum;
                oddnum += 2;
                
            }
            Console.WriteLine($"Sum: {sumNumbers}");
        }
    }
}
