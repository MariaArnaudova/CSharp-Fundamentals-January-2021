using System;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string dataType = String.Empty;
            int valueInt = 0;
            double valueDouble = 0;
            char valueChar = '\0';
            bool valueBool = true;

            while (input != "END")
            {
                if (int.TryParse(input, out valueInt))               // Integer 
                {
                    dataType = "integer";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (double.TryParse(input, out valueDouble))     // Floating point
                {
                    dataType = "floating point";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (char.TryParse(input, out valueChar))         // Characters
                {
                    dataType = "character";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (bool.TryParse(input, out valueBool))             // Boolean
                {
                    dataType = "boolean";
                    Console.WriteLine($"{input} is {dataType} type");    // Boolean
                }
                else
                {
                    dataType = "string";
                    Console.WriteLine($"{input} is {dataType} type");     // String
                }
                input = Console.ReadLine();
            }
        }
    }
}
