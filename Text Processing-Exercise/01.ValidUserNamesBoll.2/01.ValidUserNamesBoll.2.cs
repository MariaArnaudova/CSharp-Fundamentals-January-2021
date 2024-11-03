using System;

namespace _01.ValidUserNamesBoll._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineWithUsernames = Console.ReadLine().Split(", ");

            foreach (var currentUserName in lineWithUsernames)
            {
                if (IsValid(currentUserName))
                {
                    Console.WriteLine(currentUserName);
                }
            }
        }

        private static bool IsValid(string currentUserName)
        {
            return IsValidLength(currentUserName) && ConatainsValidSymbols(currentUserName);
        }

        private static bool ConatainsValidSymbols(string currentUserName)
        {
            foreach (var character in currentUserName)
            {
                if (!(character == '-' || character == '_' || char.IsLetterOrDigit(character)))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsValidLength(string currentUserName)
        {
            return currentUserName.Length >= 3 && currentUserName.Length <= 16;
        }
    }
}
