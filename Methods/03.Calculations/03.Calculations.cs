using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            // receives a string on the first line (add, multiply, subtract, divide) 
            // on the next two lines receives two numbers
            // Create four methods (for each calculation)  
            // and invoke the right one depending on the command.
            // The method should also print the result (needs to be void)

            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                AddNumbers(a, b);
            }
            else if (command == "multiply")
            {
                MultiplyNumbers(a, b);
            }
            else if (command == "subtract")
            {
                SubtractNumbers(a, b);
            }
            else if (command == "divide")
            {
                DivideNumbers(a, b);
            }
        }

        static void AddNumbers(int number1, int number2)
        {
            double result = number1 + number2;
            Console.WriteLine(result);
        }

        static void MultiplyNumbers(int number1, int number2)
        {
            double result = number1 * number2;
            Console.WriteLine(result);
        }

        static void SubtractNumbers(int number1, int number2)
        {
            double result = number1 - number2;
            Console.WriteLine(result);
        }

        static void DivideNumbers(int number1, int number2)
        {
            double result = number1 / number2;
            Console.WriteLine(result);
        }


    }
}
