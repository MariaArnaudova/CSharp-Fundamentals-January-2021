using System;
using System.Collections.Generic;

namespace _01.ValidUsernamesBoolMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineWithUsernames = Console.ReadLine().Split(", ");

            var validUserNames = new List<string>();

            foreach (var currentUserName in lineWithUsernames)
            {
                if (currentUserName.Length >= 3 && currentUserName.Length <= 16)
                {
                    bool validateContent = ValidateUser(currentUserName);

                    if (validateContent)
                    {
                        validUserNames.Add(currentUserName);
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, validUserNames));
        }

        private static bool ValidateUser(string currentUserName)
        {
            foreach (var character in currentUserName)
            {

                if (character == '-' || character == '_' || char.IsLetterOrDigit(character))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
