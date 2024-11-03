using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (PalindromeNumber(input) == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
        }

        static bool PalindromeNumber(string number)
        {
            bool isPalidrome = true;
            char[] newNumber = new char[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                newNumber[i] = number[number.Length - 1-i];
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (!(newNumber[i] == number[i]))
                {
                    isPalidrome = false;
                    return false;
                }
            }
            return true;
        }  
    }
}
