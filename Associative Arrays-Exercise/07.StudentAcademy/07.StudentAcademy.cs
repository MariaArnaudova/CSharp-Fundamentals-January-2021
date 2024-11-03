using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsGrade = new Dictionary<string, List<double>>();

            Dictionary<string, List<double>> averageGarde = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {

                string name = Console.ReadLine();

                double grade = double.Parse(Console.ReadLine());

                if (!studentsGrade.ContainsKey(name))
                {
                    studentsGrade.Add(name, new List<double>());
                    studentsGrade[name].Add(grade);
                }
                else
                {
                    studentsGrade[name].Add(grade);
                }

                //if (studentsGrade[name].Average() >= 4.50)
                //{
                //    averageGarde.Add(name, new List<double>());
                //    averageGarde[name].Add(grade);
                //}
            }
            averageGarde = studentsGrade
                    .Where(x => x.Value.Average() >= 4.50)
                    .ToDictionary(x => x.Key, x => x.Value);

            var orderStudents = averageGarde
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in orderStudents)
            {

                string name = kvp.Key;
                double averageGrade = kvp.Value.Average();

                Console.WriteLine($"{name} -> {averageGrade:F2}");

            }
        }
    }
}
