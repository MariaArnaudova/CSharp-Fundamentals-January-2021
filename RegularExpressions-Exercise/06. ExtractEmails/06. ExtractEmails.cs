using System;
using System.Text.RegularExpressions;

namespace _06._ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
           
                             //(?<=\s)(?<user>[A-Za-z0-9]+[.-]*\w*)@(?<host>[a-z]+?([.-][a-z]*)*(\.[a-z]{2,}))

            string pattern = @"(?<=\s)[A-Za-z0-9]+[\.\-_]*[A-Za-z]+@[a-z]+[\.\-]?[a-z]+[\.][a-z]+(\.?[a-z]+?)*";
            
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection emailMatches = regex.Matches(input);


            foreach (var email in emailMatches)
            {
                Console.WriteLine(email);
            }
        }
    }
}
