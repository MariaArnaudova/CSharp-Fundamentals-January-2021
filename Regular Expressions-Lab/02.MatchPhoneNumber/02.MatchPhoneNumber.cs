using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(\+359([ |-])2(\2)(\d{3})(\2)(\d{4})\b)";

            string phoneNumber = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phoneNumber, regex);

            Console.WriteLine(String.Join(", ", phoneMatches));

            // solution with  LINQ
            //string[] mathedPhones = phoneMatches.Cast<Match>()
            //    .Select(x => x.Value.Trim())
            //    .ToArray();

            //Console.WriteLine( String.Join(", ", mathedPhones));
        }
    }
}
