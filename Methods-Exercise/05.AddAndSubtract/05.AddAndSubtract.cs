using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            // receive 3 integers. Write a method Sum to get the sum of the first
            // two integers and Subtract method that subtracts the third
            //  integer from the result from the Sum method.
            int firstInt = int.Parse(Console.ReadLine());
            int secondfirstInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
            int result = GetSumOfTwoIntegers(firstInt, secondfirstInt);
            result = SubtractTwoIntegers(result, thirdInt);
            Console.WriteLine(result);

        }

        static int GetSumOfTwoIntegers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static int SubtractTwoIntegers(int a, int c)
        {
            int subtract = a - c;
            return subtract;
        }
    }
}
