using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequense = Console.ReadLine();

            StringBuilder concatCharacter = new StringBuilder();

            int powerNumber = 0;

            for (int i = 0; i < sequense.Length; i++)
            {

                char currentChar = sequense[i];

                if (currentChar == '>')
                {

                    powerNumber += int.Parse(sequense[i + 1].ToString());
                    concatCharacter.Append(currentChar);

                }
                else if (powerNumber == 0)
                {
                    concatCharacter.Append(currentChar);
                }
                else
                {
                    powerNumber --;
                }
            }

            Console.WriteLine(concatCharacter);
        }
    }
}
