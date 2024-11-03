using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method to print the smallest of three integer numbers. 
            // Use appropriate name for the method.

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintSmallestOfThreeNumbers(num1, num2, num3));
        }

        static int PrintSmallestOfThreeNumbers(int a, int b, int c)
        {
            int result = 0;
            if (a <= b && a <= c)
            {
                result += a;
            }
            else if (b <= a && b <= c)
            {
                result += b;
            }
            else if (c <= a && c <= b)
            {
                result += c;
            }
            return result;
        }

        // Vtori nachin

        //static int SmallestNumber(int a, int b, int c)
        //{
        //    return Math.Min(Math.Min(a, b), c);
        //}



    }
}
