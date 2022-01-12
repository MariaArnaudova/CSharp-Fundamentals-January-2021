using System;
using System.Linq;

namespace _04._ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that receives an array and  
            // number of rotations you have to perform (first element goes at the end)
            // Print the resulting array.

            int[] arr = Console.ReadLine() // 51 47 32 61 21
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numRotation = int.Parse(Console.ReadLine());  //  2
            numRotation = numRotation % arr.Length; // ! Optimization of code !

            //for (int i = 0; i < numRotation; i++)
            //{
            //    //int firstNumber = arr[0];
            //    //for (int j = 0; j < arr.Length - 1; j++)
            //    //{                   
            //    //    arr[j] = arr[j + 1];                                     
            //    //}
            //    //arr[arr.Length - 1] = firstNumber;
            //}                      
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
