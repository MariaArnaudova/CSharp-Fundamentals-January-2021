using System;

namespace _01.StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameStudent = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {nameStudent}, Age: {age}, Grade: {grade:F2}");
        }
    }
}
