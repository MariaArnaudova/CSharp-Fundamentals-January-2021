using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that checks if a given password is valid.Password rules are:
            //    •	6 – 10 characters(inclusive)
            //    •	Consists only of letters and digits
            //    •	Have at least 2 digits

            //   If a password is valid print "Password is valid".
            //   If it is not valid, for every unfulfilled rule print a message:
            //        •  "Password must be between 6 and 10 characters"
            //        •  "Password must consist only of letters and digits"
            //        •  "Password must have at least 2 digits"

            string password = Console.ReadLine().ToLower();

            CheckValidPassword(password);
        }

        static void CheckValidPassword(string input)
        {
            bool invalidPass = false;
            if (input.Length < 6 || input.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalidPass = true;
            }

            if (ChekForLetersAndDigits(input) == false)
            {
                invalidPass = true;
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (ChekNumOfDigitsAtLastOfText(input) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalidPass = true;
            }

            if (invalidPass==false)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool ChekForLetersAndDigits(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char currSymbol = input[i];
                if (!((currSymbol >= 48 && currSymbol <= 57) ||
                    (currSymbol >= 97 && currSymbol <= 122)))
                {
                    return false;
                }
            }
            return true;
        }
        static int ChekNumOfDigitsAtLastOfText(string input)
        {
            int digitsCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currSymbol = input[i];
                if ((currSymbol >= 48 && currSymbol <= 57))
                {
                    digitsCount++;
                }
            }
            return digitsCount;
        }
    }
}
