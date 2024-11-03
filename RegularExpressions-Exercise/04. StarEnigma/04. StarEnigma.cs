using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string patternLetter = @"[sStTaArR]";

            string decriptedPattern = @"^[^@\-!:>]*@(?<planet>[A-Za-z]+)[^@\-!:>]*\:(?<population>\d+)[^@\-!:>]*!(?<attactype>[D|A])![^@\-!:>]*?->(?<coldiersCount>\d+)[^@\-!:>]*$";

            List<string> attactPlanets = new List<string>();
            List<string> destroiedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {

                string input = Console.ReadLine();
                //MatchCollection letterCount = Regex.Matches(input, patternLetter);
                //int charCount = letterCount.Count;

                Regex letterRegex = new Regex(patternLetter);
               int charCount = letterRegex.Matches(input).Count;

                string decripted = "";

                for (int j = 0; j < input.Length; j++)
                {
                    decripted += (char)(input[j] - charCount);
                }

                Match message = Regex.Match(decripted, decriptedPattern);

                if (!message.Success)
                {
                    continue;
                }

                string name = message.Groups["planet"].Value;
                string attack = message.Groups["attactype"].Value;

                if (attack == "A")
                {

                    attactPlanets.Add(name);
                }
                else
                {
                    destroiedPlanets.Add(name);
                }
            }

            Console.WriteLine($"Attacked planets: { attactPlanets.Count}");

            attactPlanets = attactPlanets
              .OrderBy(x => x)
              .ToList();

            foreach (string planet in attactPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroiedPlanets.Count}");

            destroiedPlanets = destroiedPlanets
                .OrderBy(x => x)
                .ToList();

            foreach (string planet in destroiedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
