using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //ExtendedIndex(numbers, input);
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index > numbers.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    ExchangedIndex(numbers, index);
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        if (MaxEven(numbers) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxEven(numbers));
                    }
                    else
                    {
                        if (MaxOdd(numbers) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxOdd(numbers));
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        if (MinEven(numbers) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MinEven(numbers));
                    }
                    else
                    {
                        if (MinOdd(numbers) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MinEven(numbers));
                    }
                }
                else if (command[0] == "first")
                {
                    int count = int.Parse(command[1]);
                    if (count > numbers.Length )
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (command[2] == "even")
                    {
                        ReturnFirstEven(numbers, count);
                    }
                    else
                    {
                        ReturnFirstOdd(numbers, count);
                    }
                }
                else if (command[0] == "last")
                {
                    int count = int.Parse(command[1]);
                    if (count > numbers.Length )
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (command[2] == "even")
                    {
                        ReturnLastEven(numbers, count);
                    }
                    else
                    {
                        ReturnLastOdd(numbers, count);
                    }
                }
            }
            Console.WriteLine("[" + String.Join(", ", numbers) + "]");
        }

        static void ExchangedIndex(int[] arr, int index)
        {
            int[] firsArray = new int[arr.Length - index - 1];
            int[] secondArray = new int[index + 1];

            int firstArrCounter = 0;

            for (int i = index + 1; i < arr.Length; i++)
            {
                firsArray[firstArrCounter] = arr[i];
                firstArrCounter++;
            }

            for (int i = 0; i < index + 1; i++)
            {
                secondArray[i] = arr[i];
            }

            for (int i = 0; i < firsArray.Length; i++)
            {
                arr[i] = firsArray[i];
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                arr[firsArray.Length + i] = secondArray[i];
            }

        }

        static int MaxEven(int[] arr)
        {
            int maxEven = int.MinValue;
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] >= maxEven)
                    {
                        maxEven = arr[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int MaxOdd(int[] arr)
        {
            int maxOdd = int.MinValue;
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    if (arr[i] >= maxOdd)
                    {
                        maxOdd = arr[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int MinEven(int[] arr)
        {
            int minEven = int.MaxValue;
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] <= minEven)
                    {
                        minEven = arr[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int MinOdd(int[] arr)
        {
            int minOdd = int.MaxValue;
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    if (arr[i] <= minOdd)
                    {
                        minOdd = arr[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static void ReturnFirstEven(int[] arr, int count)
        {
            string numbers = String.Empty;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    numbers += arr[i] + " ";
                    counter++;
                }

                if (counter == count)
                {
                    break;
                }
            }

            string[] result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }

        static void ReturnFirstOdd(int[] arr, int count)
        {
            string numbers = String.Empty;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    numbers += arr[i] + " ";
                    counter++;
                }

                if (counter == count)
                {
                    break;
                }
            }

            string[] result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }

        static void ReturnLastEven(int[] arr, int count)
        {
            string numbers = String.Empty;
            int counter = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0)
                {
                    counter++;
                    numbers = arr[i] + " ";
                }

                if (counter == count)
                {
                    break;
                }

            }

            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }
        static void ReturnLastOdd(int[] arr, int count)
        {
            string numbers = String.Empty;
            int counter = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 != 0)
                {
                    counter++;
                    numbers = arr[i] + " ";
                }

                if (counter == count)
                {
                    break;
                }

            }

            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", result) + "]");
            }
        }
    }
}

