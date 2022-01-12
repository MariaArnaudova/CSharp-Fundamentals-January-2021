using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // The first line holds the length of the sequences – integer in range [1…100];
            // On the next lines until you receive "Clone them!" 
            // you will be receiving sequences(at least one) of ones and zeroes, 
            // split by "!"(one or several).

            // 1. Select the sequence with the longest subsequence of ones.
            // 2. same length of subsequence of ones, print the one with the 
            // leftmost starting index
            // "Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."

            int sequenceLength = int.Parse(Console.ReadLine());


            int currIndex = 0;
            int currSubsequenceLenght = 0;
            int currentSum = 1;
            int bestIndex = 0;
            int bestSubsequenseLength = 0;
            int bestSum = 1;
            int maxIndex = 0;
            int maxSubsequenseLength = 0;
            int maxSum = 1;
            int[] beterSequence = new int [sequenceLength];

            string input = Console.ReadLine();
            while (input != "Clone them!")
            {
                int[] currSequence = input.
                    Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int i = 0; i < currSequence.Length - 1; i++)
                {
                    currIndex = i;
                    int nextIndex = currIndex + 1;
                    if (i==1)
                    {
                        currentSum++;
                    }
                    if (currSequence[currIndex] == currSequence[nextIndex])
                    {
                        currSubsequenceLenght++;
                        currentSum += currSequence[currIndex];                       
                    }
                    else
                    {
                        currSubsequenceLenght = 0;
                    }

                    if (currSubsequenceLenght > bestSubsequenseLength)
                    {
                        bestSum = currentSum;
                        bestIndex = currIndex;
                        bestSubsequenseLength = currSubsequenceLenght;
                        if (bestSubsequenseLength >  maxSubsequenseLength)
                        {
                            maxSubsequenseLength = bestSubsequenseLength;
                            maxIndex = bestIndex;
                            maxSum = bestSum;
                            beterSequence = currSequence;
                        }
                        else if (bestSubsequenseLength == maxSubsequenseLength)
                        {
                            maxIndex = currIndex;
                        }
                    }
                }
                input = Console.ReadLine();     
            }
            Console.WriteLine($"Best DNA sample {maxIndex} with sum: {maxSum}.");
            Console.WriteLine(string.Join(" ", beterSequence));

        }

    }
}
