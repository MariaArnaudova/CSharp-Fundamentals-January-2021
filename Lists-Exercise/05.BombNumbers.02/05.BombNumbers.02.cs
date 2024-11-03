using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers._02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = bombData[0];
            int bombPower = bombData[1];
            int indexBombNumber = sequence.IndexOf(bombNumber);


            while (indexBombNumber != -1)
            {
                int leftBombNum = indexBombNumber - bombPower;
                int rightBombNum = indexBombNumber + bombPower;

                if (leftBombNum < 0)
                {
                    leftBombNum = 0;
                }

                if (rightBombNum > sequence.Count - 1)
                {
                    rightBombNum = sequence.Count - 1;
                }
                sequence.RemoveRange(leftBombNum, rightBombNum - leftBombNum + 1);

                indexBombNumber = sequence.IndexOf(bombNumber);
            }
            int sumElements = sequence.Sum();
            Console.WriteLine(sumElements);
        }
    }
}
