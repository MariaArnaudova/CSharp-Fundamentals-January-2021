using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudent = int.Parse(Console.ReadLine());

            List<Student> newStudents = new List<Student>();

            for (int i = 0; i < numberStudent; i++)
            {
                string[] studentData = Console.ReadLine().Split();
                //        //"{first name} {second name} {grade}"
                string firstName = studentData[0];
                string lastName = studentData[1];
                double garde = double.Parse(studentData[2]);

                Student currentStudent = new Student(firstName, lastName, garde);
                newStudents.Add(currentStudent);
            }
            List<Student> descendingOrder = newStudents
                .OrderByDescending(newStudents => newStudents.Grade).ToList();

            foreach (Student currStudent in descendingOrder)
            {
                Console.WriteLine($"{currStudent.FirstName} {currStudent.LastName}: {currStudent.Grade:F2}");
            }
            
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

    }
}
