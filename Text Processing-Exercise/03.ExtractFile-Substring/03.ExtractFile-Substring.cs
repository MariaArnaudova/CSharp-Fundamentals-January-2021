using System;

namespace _03.ExtractFile_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int startIndexFile = input.LastIndexOf('\\') + 1;

            string file = input.Substring(startIndexFile);

            int startIndexExtention = file.LastIndexOf('.') + 1;

            string name = file.Substring(0, startIndexExtention-1);

            string extention = file.Substring(startIndexExtention);

            Console.WriteLine($"File name: { name}");
            Console.WriteLine($"File extension: {extention} ");
        }
    }
}
