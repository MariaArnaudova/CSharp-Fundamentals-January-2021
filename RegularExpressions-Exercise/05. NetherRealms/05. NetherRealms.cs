using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demonsInfo = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Demon> demonsType = new Dictionary<string, Demon>();

            string patternHealth = @"[^\d\-+.*,\/]";           //[^\d+\-*,\/\. \t]   // name \b[\w\W]+[^\,''\t]\b
            string patternDamage = @"[\-+\.]{0,1}\d+\.?\d*";  // @"\d[-+\.]?\d?"
            string patternStar = @"\*";
            string patternLine = @"\/";


            Regex regexHealth = new Regex(patternHealth);
            Regex regexDamage = new Regex(patternDamage);
            Regex regexStar = new Regex(patternStar);
            Regex regexLine = new Regex(patternLine);

            foreach (string demon in demonsInfo)
            {
                MatchCollection matchHealth = regexHealth.Matches(demon);
                int healht = matchHealth.Sum(x => (char.Parse(x.Value)));

                //var health = regexHealth.Matches(demon)
                //    .Select(x => char.Parse(x.Value))
                //    .Sum(x => x);
                MatchCollection matchDamage = regexDamage.Matches(demon);
                double damage = matchDamage.Sum(x => double.Parse(x.Value));

                MatchCollection matchStar = regexStar.Matches(demon);
                var starCount = matchStar.Count(); // false!!! var starCount = matchStar.Where(x => x.Value == "*").Count();

                MatchCollection matchLine = regexLine.Matches(demon);
                var lineCount = matchLine.Count();  //  false!!! var lineCount = matchLine.Where(x => x.Value == "-").Count();

                if (demon.Contains("*"))
                {
                    for (int i = 0; i < starCount; i++)
                    {
                        damage *= 2;
                    }    
                }

                if (demon.Contains("/"))
                {
                    for (int i = 0; i < lineCount; i++)
                    {
                        damage /=2;
                    }
                }

                if (!demonsType.ContainsKey(demon))
                {
                    Demon newDemon = new Demon(healht, damage);

                    demonsType.Add(demon, newDemon);
                }
                demonsType[demon].Health = healht;
                demonsType[demon].Damage = damage;
            }

            var sortedDemons = demonsType
                .OrderBy(x => x.Key)
                .Select(x=>x)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in sortedDemons)
            {
                Console.WriteLine($"{item.Key} - {sortedDemons[item.Key].Health} health, {sortedDemons[item.Key].Damage:F2} damage");
            }
        }

    }
    class Demon
    {
        public int Health { get; set; }

        public double Damage { get; set; }

        public Demon(int health, double damage)
        {
            this.Health = health;
            this.Damage = damage;
        }
    }
}
