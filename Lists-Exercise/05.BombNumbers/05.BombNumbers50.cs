using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            //int[] bombData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] bombData = Console.ReadLine().Split(" ");


            int bombNumber = int.Parse(bombData[0].ToString());
            int bombPower = int.Parse(bombData[1].ToString());

            int indexBombNumber = sequence.IndexOf(bombNumber);

            while (indexBombNumber!=-1)
            {
                int counter1 = 0;
                for (int i = indexBombNumber - bombPower; i < indexBombNumber; i++)
                {
                    counter1++;
                    if (counter1 <= bombPower)
                    {
                        sequence.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        break;
                    }
                }
                int counter2 = 0;           
                indexBombNumber -= bombPower;
                for (int i = indexBombNumber + 1; i <= indexBombNumber + bombPower; i++)
                {
                    if (i > sequence.Count - 1)
                    {                       
                        i = sequence.Count-1;                       
                        sequence.RemoveAt(i);
                        break;
                    }
                    else
                    {
                        counter2++;
                        if (counter2 <= bombPower)
                        {
                            sequence.RemoveAt(i);
                            i--;
                        }
                    }
                }
                sequence.Remove(bombNumber);
                indexBombNumber = sequence.IndexOf(bombNumber);
            }
            int sumSequence = sequence.Sum();
            Console.WriteLine(sumSequence);
            /*int range = sequence[indexBombNumber]*/

            //while (sequence.Contains(bombNumber))
            //{
            //    int numRemove = bombPower * 2 + 1;
            //    if (bombPower + indexBombNumber > sequence.Count)
            //    {
            //        numRemove = bombPower + (sequence.Count - (indexBombNumber));
            //    }
            //    sequence.RemoveRange(indexBombNumber - bombPower, numRemove);
            //}
            //Console.WriteLine(sequence.Sum());
            //Console.WriteLine(String.Join(" ", sequence));
        }
    }
}
