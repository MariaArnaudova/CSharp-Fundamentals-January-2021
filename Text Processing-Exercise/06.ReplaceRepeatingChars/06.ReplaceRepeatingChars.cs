using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        public static object StrinBuilder { get; private set; }

        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();

            //StringBuilder newSequence = new StringBuilder();
            string newSequence = "";

            for (int i = 0; i < sequence.Length-1 ; i++)
            {

                if (sequence[i + 1] != sequence[i])
                {
                    newSequence += (sequence[i]);
                }             
            }
            newSequence += sequence[sequence.Length - 1];

            Console.WriteLine(newSequence);
        }
    }
}
