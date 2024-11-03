using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // You will receive a single string. Write a method that prints the middle character. 
            //If the length of the string is even there are two middle characters.

            string text = Console.ReadLine();
            PrintMiddleCharacters(text);
        }
        static void PrintMiddleCharacters(string input)
        {
            string result = "";
            if (input.Length % 2 == 1)
            {
                int lengthEqualsPart = input.Length / 2;
                result += input[lengthEqualsPart];
            }
            else
            {
                int lengthEqualsPart = input.Length / 2;
                for (int i = lengthEqualsPart - 1; i <= lengthEqualsPart; i++)
                {
                    result += input[i];
                }  
            }
            Console.WriteLine(result);
        }
    }
}
