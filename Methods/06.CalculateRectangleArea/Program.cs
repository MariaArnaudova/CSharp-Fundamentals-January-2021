using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int area = CalcRectangleArea(length, width );
            Console.WriteLine(area);
            
        }
       static int CalcRectangleArea(int length, int width)
        {
          return(length * width);     
        }
    }
}
