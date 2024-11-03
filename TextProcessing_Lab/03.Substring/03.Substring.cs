using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            string sequence = Console.ReadLine();
            int removeIndex = 0;

            while (true)
            {

                removeIndex = sequence.IndexOf(word);

                if (removeIndex < 0)
                {
                    break;
                }

                sequence = sequence.Remove(removeIndex, word.Length);

            }
            Console.WriteLine(sequence);

            //int lengthSequence = sequence.Length;

            //for (int i = 0; i < lengthSequence; i++)
            //{
            //    removeIndex = sequence.IndexOf(word);

            //    if (removeIndex < 0)
            //    {
            //        break;
            //    }
            //    sequence = sequence.Remove(removeIndex, word.Length);
            //}
            //Console.WriteLine(sequence);
        }
    }
}
