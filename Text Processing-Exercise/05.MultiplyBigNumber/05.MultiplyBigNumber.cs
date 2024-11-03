using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            int mulitplyCurrNum = 0;
            int mindNum = 0;

            if (secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (bigNumber[0]=='0')
            {
                bigNumber = bigNumber.Substring(1);
            }

            StringBuilder sb = new StringBuilder();

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {

                mulitplyCurrNum = int.Parse(bigNumber[i].ToString()) * secondNumber + mindNum;
                mindNum = 0;


                if (mulitplyCurrNum > 9)
                {              
                    mindNum = mulitplyCurrNum / 10;
                    mulitplyCurrNum = mulitplyCurrNum % 10;

                }
                
                sb.Append(mulitplyCurrNum);
            }

            if (mindNum!=0)
            {
                sb.Append(mindNum);

            }

            StringBuilder finalNumber = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                finalNumber.Append(sb[i]);
            }

            Console.WriteLine(finalNumber);
        }
    }
}
