using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {                    
            double volume = 0;
                      
            double lenght = double.Parse(Console.ReadLine());
            Console.Write($"Length: ");           
            double widht= double.Parse(Console.ReadLine());
            Console.Write($"Width: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write($"Height: ");            
            volume = (lenght * widht * height) / 3.0;
            Console.Write($"Pyramid Volume: {volume:F2}");

        }
    }
}
