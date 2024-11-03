using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sumRemovedEllements = 0;
            int removeEllement =0;

            while (numbers.Count > 0)
            {
              
                int currentIndex = int.Parse(Console.ReadLine());
  
                if (currentIndex < 0)
                {
                    currentIndex = 0;
                    removeEllement = numbers[currentIndex];
                    sumRemovedEllements += removeEllement;
                    //numbers.RemoveAt(currentIndex);
                    //numbers.Insert(0, numbers.Count - 1);
                    numbers[0] = numbers[numbers.Count - 1];
                }
                else if (currentIndex > numbers.Count - 1)
                {
                    currentIndex = numbers.Count - 1;
                    removeEllement = numbers[currentIndex];
                    sumRemovedEllements += removeEllement;
                    //numbers.RemoveAt(currentIndex);
                    //numbers.Insert(currentIndex, numbers[0]);
                    numbers[numbers.Count - 1] = numbers[0];

                }
                else if (currentIndex >= 0 && currentIndex <= numbers.Count - 1)
                {
                    removeEllement = numbers[currentIndex];
                    sumRemovedEllements += removeEllement;
                    numbers.RemoveAt(currentIndex);

                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= removeEllement)
                    {
                        numbers[i] += removeEllement;
                    }
                    else if (numbers[i] > removeEllement)
                    {
                        numbers[i] -= removeEllement;
                    }
                }
            }
            Console.WriteLine(sumRemovedEllements);
        }
    }
}
