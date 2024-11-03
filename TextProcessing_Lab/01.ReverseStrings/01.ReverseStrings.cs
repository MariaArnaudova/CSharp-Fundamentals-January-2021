using System;
using System.Linq;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string reversedWord = string.Empty;

            while (text != "end")
            {
                reversedWord = string.Empty;

                for (int i = text.Length-1; i >= 0; i--)
                {

                    reversedWord += text[i];

                }

                Console.WriteLine($"{text} = {reversedWord}");
                text = Console.ReadLine();
            }


            //reversedWord = new string(text.Reverse().ToArray());

            //reversedWord = text.Reverse().ToString();

            //char[] temp = text.ToCharArray();
            //reversedWord = new string(temp.Reverse().ToArray()); 


        }
    }
}
