using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // The possible operators are: / * + -

            int number1 = int.Parse(Console.ReadLine());
            string operators =  Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());
            double result = 0;
            switch (operators)
            {
                case "/":
                    result = MathOperationDivide(number1, number2);
                break;
                case "*":
                    result = MathOperationMultiply(number1, number2);
                    break;
                case "+":
                    result = MathOperationSum(number1, number2);
                    break;
                case "-":
                   result = MathOperationSubtract(number1, number2);
                    break;
                default:
                    break;
            }
            Console.WriteLine(result);
        }

        static double MathOperationDivide(double n1, double n2)
        {
            double result = n1 / n2;
            return result;
        }

        static double MathOperationMultiply(double n1, double n2)
        {
            double result = n1 * n2;
            return result;
        }
        static double MathOperationSubtract(double n1, double n2)
        {
            double result = n1 - n2;
            return result;
        }
        static double MathOperationSum(double n1, double n2)
        {
            double result = n1 + n2;
            return result;
        }
    }
}
