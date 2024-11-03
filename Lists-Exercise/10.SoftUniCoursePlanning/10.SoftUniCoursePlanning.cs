using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();
            string lessonLabTitle = "";
            //string secondLesson = "";
            int index = 0;

            while (input != "course start")
            {
                string[] commands = input
                    .Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                lessonLabTitle = commands[1];

                if (commands[0] == "Add")
                {
                    if (lessons.Contains(lessonLabTitle))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        lessons.Add(lessonLabTitle);
                    }
                }
                else if (commands[0] == "Insert")
                {
                    index = int.Parse(commands[2]);
                    if (lessons.Contains(lessonLabTitle))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        lessons.Insert(index, lessonLabTitle);
                    }
                }
                else if (commands[0] == "Remove")
                {
                    if (lessons.Contains(lessonLabTitle))
                    {
                        lessons.Remove(lessonLabTitle);
                        if (lessons.Contains(lessonLabTitle + "-Exercise"))
                        {
                            lessons.Remove(lessonLabTitle + "-Exercise");
                        }
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (commands[0] == "Swap")
                {
                    string secondLesson = commands[2];

                    int firstLessonIndex = lessons.IndexOf(lessonLabTitle);
                    int secondLessonIndex = lessons.IndexOf(secondLesson);
                    if (firstLessonIndex != -1 && secondLessonIndex != -1)
                    {
                        if (lessons.Contains(lessonLabTitle) && 
                            lessons.Contains(secondLesson))
                        {
                            string temp = lessons[firstLessonIndex];
                            lessons[firstLessonIndex] = secondLesson;
                            lessons[secondLessonIndex] = lessonLabTitle;

                            string FirstLessonExercise = lessonLabTitle + "-Exercise";
                            int indexFirstExercise = firstLessonIndex + 1;

                            string secondLessonExercise = secondLesson + "-Exercise";
                            int indexSecondExercise = secondLessonIndex + 1;

                            if (indexFirstExercise < lessons.Count &&
                                 lessons.Contains(FirstLessonExercise))
                            {
                                firstLessonIndex = lessons.IndexOf(FirstLessonExercise);
                                lessons.Insert(indexSecondExercise, FirstLessonExercise);
                                lessons.RemoveAt(indexFirstExercise);
                            }
                            if (indexSecondExercise < lessons.Count 
                                && lessons.Contains(secondLessonExercise))
                            {
                                secondLessonIndex = lessons.IndexOf(secondLessonExercise);
                                lessons.Insert(indexFirstExercise, secondLessonExercise);
                                lessons.RemoveAt(indexSecondExercise + 1);
                            }
                        }
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (commands[0] == "Exercise")
                {
                    int indexLab = lessons.IndexOf(lessonLabTitle);
                    string exerciseLesson = lessonLabTitle + "-Exercise";

                    if (lessons.Contains(lessonLabTitle)&& !(lessons.Contains(exerciseLesson)))
                    {                
                        lessons.Insert(indexLab + 1, exerciseLesson);
                    }
                    else if(!lessons.Contains(lessonLabTitle))
                    {
                        lessons.Add(lessonLabTitle);
                        lessons.Add(exerciseLesson);
                    }
                }
                input = Console.ReadLine();
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
