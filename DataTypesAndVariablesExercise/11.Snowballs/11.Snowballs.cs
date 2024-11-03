using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            //	On the first line you will get the snowballSnow – an integer.
            // On the second line you will get the snowballTime – an integer.
            // On the third line you will get the snowballQuality – an integer.
            //For each snowball you must calculate its snowballValue by the following formula:
            //(snowballSnow / snowballTime) ^ snowballQuality

            int nNumberOfballs = int.Parse(Console.ReadLine());

            BigInteger highesValue = 0;
            int highesSnow = 0;
            int highesTime = 0;
            int highesQuality = 0;

            for (int i = 0; i < nNumberOfballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > highesValue)
                {
                    highesValue = snowballValue;
                    highesSnow = snowballSnow;
                    highesTime = snowballTime;
                    highesQuality = snowballQuality;
                }   
            }
            Console.WriteLine($"{ highesSnow} : { highesTime} =" +
                             $" { highesValue} ({ highesQuality})");
        }
    }
}
