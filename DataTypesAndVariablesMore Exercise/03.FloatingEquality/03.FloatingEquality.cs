using System;

namespace _03.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            // precision eps = 0.000001

            double difference = Math.Abs(numberA - numberB);

            bool isDifferent = false;
            if (difference < 0.000001)
            {
                isDifferent = true;
            }
            else
            {
                isDifferent = false;
            }
            Console.WriteLine(isDifferent);
        }
    }
}
