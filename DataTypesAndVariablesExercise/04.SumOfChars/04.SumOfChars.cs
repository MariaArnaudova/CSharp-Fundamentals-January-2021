using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which sums the ASCII codes
            // of n characters and prints the sum on the console.

            uint nNumbers = uint.Parse(Console.ReadLine());

            uint totalSumAsciiCodes = 0;

            for (int i = 1; i <= nNumbers; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                uint letterValue = (uint)letter;
                if ((60 <= letterValue && letterValue <= 90) || (97 <= letterValue && letterValue <= 122))
                {
                    totalSumAsciiCodes += letterValue ;
                }      

            }
            Console.WriteLine($"The sum equals: {totalSumAsciiCodes}");
        }
    }
}
