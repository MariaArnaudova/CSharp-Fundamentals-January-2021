using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = Console.ReadLine().Split().ToList();

            List<Student> allStudent = new List<Student>();

            while (students[0] != "end")
            {
              
                string firstName = students[0];
                string lastName = students[1];
                int age = int.Parse(students[2]);
                string homeTown = students[3];

                Student oneStudent = new Student();

                oneStudent.FirstName = firstName;
                oneStudent.LastName = lastName;
                oneStudent.Age = age;
                oneStudent.HomeTown = homeTown;

                allStudent.Add(oneStudent);

                students = Console.ReadLine().Split().ToList();

            }
            string nameOfCitye = Console.ReadLine();

            foreach (Student onestudent in allStudent)
            {
                if (nameOfCitye == onestudent.HomeTown)
                {
                    Console.WriteLine($"{onestudent.FirstName} {onestudent.LastName} is {onestudent.Age} years old.");
                }
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
}
