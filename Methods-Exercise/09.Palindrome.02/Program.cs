using System;
using System.Linq;

namespace _09.Palindrome._02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
;
            while (input!="END")
            {
                Console.WriteLine(IsPalindromeNumber(input).ToString().ToLower());
                input = Console.ReadLine();
            }

        }

        static bool IsPalindromeNumber(string text)
        {
            char[] reversed = text.Reverse().ToArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (!(reversed[i]==text[i]))
                {
                    return false;
                }
            }
            return true;

        }
    }
}
