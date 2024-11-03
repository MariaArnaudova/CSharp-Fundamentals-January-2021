using System;

namespace _07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read two names and a delimiter. Print the names joined by the delimiter.

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimiter = Console.ReadLine();
           
            Console.WriteLine($"{firstName}{delimiter}{lastName}");
        }
    }
}
