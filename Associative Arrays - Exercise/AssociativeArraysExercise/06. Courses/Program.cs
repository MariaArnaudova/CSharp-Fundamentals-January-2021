using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesLists = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] courseInfo = input.Split(" : ");

                string course = courseInfo[0];
                string studentName = courseInfo[1];

                if (!coursesLists.ContainsKey(course))
                {
                    coursesLists.Add(course, new List<string>());
                    coursesLists[course].Add(studentName);
                }
                else
                {
                    if (!coursesLists[course].Contains(studentName))
                    {
                        coursesLists[course].Add(studentName);
                    }
                }

                input = Console.ReadLine();
            }

            coursesLists = coursesLists
                .OrderByDescending(s => s.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in coursesLists)
            {
                string courseName = kvp.Key;
                int registeredStudent = kvp.Value.Count;

                Console.WriteLine($"{ courseName}: { registeredStudent}");

                List<string> students = kvp.Value;
                students = students.OrderBy(x => x).ToList();

                foreach (var student in students)
                {

                    Console.WriteLine($"-- {student}");

                }
            }
        }
    }
}
