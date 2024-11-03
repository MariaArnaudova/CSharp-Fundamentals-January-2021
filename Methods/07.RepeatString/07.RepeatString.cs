using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            // The method should return a new string (the old one repeated n times)

            string input = Console.ReadLine();
            int timesRepeat = int.Parse(Console.ReadLine());
            string lastString = RepeatStringMoreTimes(input, timesRepeat);
            Console.WriteLine(lastString);

        }
        static string RepeatStringMoreTimes(string input, int n)
        {
            string newString = String.Empty;
            for (int i = 0; i < n; i++)
            {
                 newString += input;
            }
            return newString;
        }
    }
}
