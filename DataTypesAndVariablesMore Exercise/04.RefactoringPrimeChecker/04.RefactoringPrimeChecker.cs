using System;

namespace _04.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int endRange = int.Parse(Console.ReadLine());
            
            for (int numInRange = 2; numInRange <= endRange; numInRange++)
            {
                bool isPrime = true;
                for (int divider = 2; divider < numInRange; divider++)
                {
                    if (numInRange % divider == 0)
                    {
                        isPrime = false;
                        continue;
                    }                  
                }
                if (isPrime == true)
                {
                    string isPrimeNum = "true";
                    Console.WriteLine("{0} -> {1}", numInRange, isPrimeNum);                  
                }
                else
                {
                    string isNotPrimeNum = "false";
                    Console.WriteLine("{0} -> {1}", numInRange, isNotPrimeNum);
                }               
            }
        }
    }
}
