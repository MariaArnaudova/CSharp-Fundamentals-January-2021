using System;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which prints common elements in two arrays. 
            // You have to compare the elements of the second array 
            // to the elements of the first.

            // Hey hello 2 4
            // 10 hey 4 hello
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            string newLine = "";

            for (int i = 0; i < arr2.Length; i++)
            {
                string elementArr2 = arr2[i];
                for (int j = 0; j < arr1.Length; j++)
                {
                    string elementArr1 = arr1[j];
                    if (elementArr2==elementArr1)
                    {
                        newLine += elementArr2 + " ";
                    }
                }
            }
            Console.WriteLine(newLine);
        }
    }
}
