using System;
using System.Text;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {

               char currentChar = (char)(text[i] + 3);
                sb.Append(currentChar);

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
