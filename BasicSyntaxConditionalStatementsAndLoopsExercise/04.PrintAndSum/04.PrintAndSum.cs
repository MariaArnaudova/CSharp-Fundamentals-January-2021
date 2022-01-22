using System;

namespace _04.PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firsNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());

            int sum = 0;
            int currentNum = 0;

            for (int i = firsNum; i <= lastNum; i++)
            {
                currentNum = i;
                sum += currentNum;
                Console.Write($"{currentNum} "); 
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
