using System;
using System.Linq;
namespace _05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string characters = Console.ReadLine();
            string digit = String.Empty;
            string leters = String.Empty;
            string otherDigits = String.Empty;

            foreach (char currrChar in characters)
            {
                if (char.IsDigit(currrChar))
                {
                    digit += currrChar;
                }
                else if (char.IsLetter(currrChar))
                {
                    leters += currrChar;

                }
                else
                {
                    otherDigits += currrChar;
                }
            }

            Console.WriteLine(digit);
            Console.WriteLine(leters);
            Console.WriteLine(otherDigits);
        }
    }
}
