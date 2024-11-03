using System;

namespace _06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            int sumValueChar = 0;
            string previous = "";

            for (int i = 1; i <= nLines; i++)
            {
                string currentChar = Console.ReadLine();
                for (int j = 0; j < currentChar.Length; j++)
                {                   
                    if (currentChar == "(" || currentChar == ")")
                    {                     
                        previous = currentChar;
                        sumValueChar += currentChar[j];
                    }
                }
            }
            if (sumValueChar % 81 == 0)
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
