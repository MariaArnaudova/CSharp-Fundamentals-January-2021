using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> kmOfParticipats = new Dictionary<string, int>();

            string parrernName = @"[A-Za-z]";
            string patternDistance = @"\d";

            string[] participants = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();

            //string name = "";
            //int distance = 0;

            while (input != "end of race")
            {

                Regex regexName = new Regex(parrernName);
                Regex regexDistance = new Regex(patternDistance);

                MatchCollection charsName = regexName.Matches(input);
                MatchCollection numbers = regexDistance.Matches(input);

                string name = String.Concat(charsName);
                int sumOfKm = numbers.Select(x => int.Parse(x.Value)).Sum();

                //foreach (Match currChar in charsName)
                //{
                //    name += currChar;
                //}

                //foreach (Match item in numbers)
                //{
                //    distance += int.Parse(item.Value);
                //}

                if (participants.Contains(name))
                {
                    if (kmOfParticipats.ContainsKey(name))
                    {
                        kmOfParticipats[name] += sumOfKm;
                    }
                    else
                    {
                        kmOfParticipats.Add(name, sumOfKm);
                    }
                }

                input = Console.ReadLine();
            }

            string[] sorted = kmOfParticipats
                .OrderByDescending(x => x.Value)
                .Select(x => x.Key) // convert to string
                .Take(3)
                .ToArray();

            Console.WriteLine($"1st place: {sorted[0]}");
            Console.WriteLine($"2nd place: {sorted[1]}");
            Console.WriteLine($"3rd place: {sorted[2]}");
        }
    }
}
