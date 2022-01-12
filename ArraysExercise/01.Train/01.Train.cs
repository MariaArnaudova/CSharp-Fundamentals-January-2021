using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            // n count of wagons
            // next line - number of people to get in each wagon
            // print the whole train and sum of the people of the train

            int n = int.Parse(Console.ReadLine());

            int[] train = new int[n];
            int sum = 0;

            for (int wagons = 0; wagons < n; wagons++)
            {
                int numberPeople = int.Parse(Console.ReadLine());
                train[wagons] = numberPeople;
                sum += numberPeople;
            }
            Console.WriteLine(String.Join(" ", train));
            Console.WriteLine(sum);
        }
    }
}
