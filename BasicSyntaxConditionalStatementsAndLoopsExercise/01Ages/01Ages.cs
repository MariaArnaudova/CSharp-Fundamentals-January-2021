using System;

namespace _01Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            string typePerson = "";
            if (ages >= 0 && ages <= 2)
            {
                typePerson = "baby";
            }
            else if (ages >= 3 && ages <= 13)
            {
                typePerson = "child";
            }
            else if (ages >= 14 && ages <= 19)
            {
                typePerson = "teenager";
            }
            else if (ages >= 20 && ages <= 65)
            {
                typePerson = "adult";
            }
            else if (ages >= 66)
            {
                typePerson = "elder";
            }
            Console.WriteLine($"{typePerson}");
        }
    }
}
