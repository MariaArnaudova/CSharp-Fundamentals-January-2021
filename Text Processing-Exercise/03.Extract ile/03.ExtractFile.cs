using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Extract_ile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries).ToList();


            string[] lastString = input[input.Count - 1].Split('.', StringSplitOptions.RemoveEmptyEntries);
            string fileName = lastString[0].ToString();

            string extention = string.Empty;

            extention = lastString[1].ToString();

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extention}");

        }
    }
}
