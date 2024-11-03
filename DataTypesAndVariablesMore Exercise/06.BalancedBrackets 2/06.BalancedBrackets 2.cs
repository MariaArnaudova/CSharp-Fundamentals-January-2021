using System;

namespace _06.BalancedBrackets_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            int countOpenBrackets = 0;
            int countClosedBrackets = 0;

            for (int i = 0; i < nLines; i++)
            {
                string currentChar = Console.ReadLine();

                if (currentChar == "(")
                {
                    countOpenBrackets++;
                }

                if (currentChar == ")")
                {
                    countClosedBrackets++;

                    if (countOpenBrackets - countClosedBrackets != 0)
                    {
                        break;
                    }
                }
            }

            if (countOpenBrackets == countClosedBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
