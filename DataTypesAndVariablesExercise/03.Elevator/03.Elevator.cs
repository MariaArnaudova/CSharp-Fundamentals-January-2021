using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int numberFullCourses = numberPeople / capacity;
            if (numberPeople % capacity != 0)
            {
                int leftNumberPeople = numberPeople % capacity;
                numberFullCourses ++;
            }
            Console.WriteLine($"{numberFullCourses}");
        }
    }
}
