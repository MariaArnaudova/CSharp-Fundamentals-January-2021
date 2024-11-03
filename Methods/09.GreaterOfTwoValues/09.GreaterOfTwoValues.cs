using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method GetMax() that returns the greater of two values 
            // (the values can be of type int, char or string)

            string valuesType = Console.ReadLine();

            if (valuesType == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int maxValue = GetMaxValue(num1, num2);
                Console.WriteLine(maxValue);
            }
            else if (valuesType == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
                char maxValue = GetMaxValue(char1, char2);
                Console.WriteLine(maxValue);
            }
            else if (valuesType == "string")
            {
                string value1 = Console.ReadLine();
                string value2 = Console.ReadLine();
                string maxValue = GetMaxValue(value1, value2);
                Console.WriteLine(maxValue);
            }

        }

        static int GetMaxValue(int a, int b)
        {
            if (a < b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }

        static char GetMaxValue(char a, char b)
        {
            if (a < b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }

        static string GetMaxValue(string a, string b)
        {
            int compare = a.CompareTo(b);
            if (compare > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
