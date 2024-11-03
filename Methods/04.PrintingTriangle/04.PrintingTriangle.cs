using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method for printing triangles as shown below:

            int input = int.Parse(Console.ReadLine());

            PrintTriangles(input);
        }

        static void PrintTriangles(int input)
        {

            for (int rows = 1; rows <= input; rows++)
            {
                PrintLine(rows);
            }

            for (int rows = input - 1; rows >= 1; rows--)
            {
                PrintLine(rows);

            }

            static void PrintLine(int rows)
            {
                for (int colums = 1; colums <= rows; colums++)
                {
                    Console.Write(colums + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
