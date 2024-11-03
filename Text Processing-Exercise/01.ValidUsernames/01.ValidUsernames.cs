using System;
using System.Collections.Generic;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineWithUsernames = Console.ReadLine().Split(", ");

            var validUserName = new List<string>();

            foreach (var currentUserName in lineWithUsernames)
            {

                if ((currentUserName.Length >= 3 && currentUserName.Length <= 16))
                {

                    bool isValidUserName = true;

                    foreach (var currentcChar in currentUserName)
                    {

                        if (!(currentcChar == '-' || currentcChar == '_' || char.IsLetterOrDigit(currentcChar)))
                        {

                            isValidUserName = false;
                            break;
                        }          
                    }
                    if (isValidUserName)
                    {
                        validUserName.Add(currentUserName);
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, validUserName));
        }
    }
}
