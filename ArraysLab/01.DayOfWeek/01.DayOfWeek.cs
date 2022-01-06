using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {

            // Enter a day number [1…7] and print the name (in English) or "Invalid day!"
            int dayNumber = int.Parse(Console.ReadLine());

            string[] dayOfWeek = new string[7];
            dayOfWeek[0] = "Monday";
            dayOfWeek[1] = "Tuesday";
            dayOfWeek[2] = "Wednesday";
            dayOfWeek[3] = "Thursday";
            dayOfWeek[4] = "Friday";
            dayOfWeek[5] = "Saturday";
            dayOfWeek[6] = "Sunday";

            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine(dayOfWeek[dayNumber-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
