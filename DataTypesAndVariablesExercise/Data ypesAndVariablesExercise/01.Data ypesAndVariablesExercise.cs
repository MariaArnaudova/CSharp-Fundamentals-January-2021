using System;

namespace Data_ypesAndVariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;

            double divide = sum / thirdNumber * 1.0;

            double result = divide * fourthNumber;
            Console.WriteLine($"{result}");

        }
    }
}
