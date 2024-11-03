using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> student = Console.ReadLine().Split().ToList();

            List<Student> allStudent = new List<Student>();

            while (student[0] != "end")
            {
                string firstName = student[0];
                string lastName = student[1];
                int age = int.Parse(student[2]);
                string homeTown = student[3];


                if (IsStudentExisting(allStudent, firstName, lastName))
                {
                    Student existStudent = GetStudent(allStudent, firstName, lastName);

                    existStudent.FirstName = firstName;
                    existStudent.LastName = lastName;
                    existStudent.Age = age;
                    existStudent.HomeTown = homeTown;

                }
                else
                {
                    Student currentStudent = new Student();

                    currentStudent.FirstName = firstName;
                    currentStudent.LastName = lastName;
                    currentStudent.Age = age;
                    currentStudent.HomeTown = homeTown;

                    allStudent.Add(currentStudent);
                }

                student = Console.ReadLine().Split().ToList();
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
        public static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        public static Student GetStudent(List<Student> students, string firstName, string lasstName)
        {
            Student existingStudent = null;
            foreach (Student currStudent in students)
            {
                if (currStudent.FirstName == firstName && currStudent.LastName == lasstName)
                {
                    existingStudent = currStudent;
                }
            }
            return existingStudent;
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
