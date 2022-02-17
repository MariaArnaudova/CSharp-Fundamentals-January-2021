using System;

namespace _10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTable = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <=10; i++)
            {
                result = numTable * i;
                Console.WriteLine($"{numTable} X {i} = {result}");
            }
        }
    }
}
