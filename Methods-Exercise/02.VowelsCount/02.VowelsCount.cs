using System;
using System.Linq;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that receives a single string and prints the count of the vowels. 
            // Use appropriate name for the method.

            string input = Console.ReadLine().ToLower();
            PrintsSumOfVowelFromWord(input);
        }

        static void PrintsSumOfVowelFromWord(string input)
        {
            int countVowels = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 97 || input[i] == 101 ||
                    input[i] == 105 || input[i] == 111 || input[i] == 117)
                {
                    countVowels++;
                }
            }
            Console.WriteLine(countVowels);

            //static void PrintsSumOfVowelFromWord(string input)
            //{
            //    int countVowels = 0;
            //    for (int i = 0; i < input.Length; i++)
            //    {
            //        switch (input[i])
            //        {
            //            case 'a':
            //            case 'e':
            //            case 'i':
            //            case 'o':
            //            case 'u':
            //                countVowels++;
            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //    Console.WriteLine(countVowels);
            //}

            //static void PrintsSumOfVowelFromWord(string input)
            //{
            //    int countVowels = 0;
            //    char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            //    for (int i = 0; i < input.Length; i++)
            //    {
            //        if (vowels.Contains(input[i]))
            //        {
            //            countVowels++;
            //        }
            //    }
            //    Console.WriteLine(countVowels);
            //}

        }
    }
}
