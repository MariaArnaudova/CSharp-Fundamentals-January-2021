using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string usserName = Console.ReadLine();
            string password = "";

            for (int i = usserName.Length - 1; i >= 0; i--)
            {
                password += usserName[i];
            }
            int countLogg = 0;

            string currentPassword = Console.ReadLine();

            while (currentPassword != password)
            {
                countLogg++;

                if (countLogg == 4)
                {
                    Console.WriteLine($"User {usserName} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                currentPassword = Console.ReadLine();
            }
            if (currentPassword == password)
            {
                Console.WriteLine($"User {usserName} logged in.");

            }

        }
    }
}
