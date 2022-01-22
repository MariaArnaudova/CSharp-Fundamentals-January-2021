using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Students – if the group is bigger than or equal to 30 people you should reduce the total price by 15%
            // Business – if the group is bigger than or equal to  100 people 10 of them can stay for free.
            // Regular – if the group is bigger than or equal to 10 and less than or equal to 20 reduce the total price by 5 %

            //	          Friday  Saturday	Sunday
            //  Students    8.45    9.80    10.46
            //  Business    10.90   15.60   16
            //  Regular      15      20     22.50

            int numberPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double totalPrice = 0.0;
            string result = "";

            if (dayOfWeek == "Friday")
            {
                if (typeGroup == "Students")
                {
                    totalPrice = numberPeople * 8.45;

                    if (numberPeople >= 30)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                }
                else if (typeGroup == "Business")
                {
                    if (numberPeople >= 100)
                    {
                        numberPeople -= 10;
                    }
                    totalPrice = numberPeople * 10.90;

                }
                else if (typeGroup == "Regular")
                {
                    totalPrice = numberPeople * 15;

                    if (numberPeople >= 10 && numberPeople <= 20)
                    {
                        totalPrice -= totalPrice * 0.05;
                    }
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                if (typeGroup == "Students")
                {
                    totalPrice = numberPeople * 9.80;
                    if (numberPeople >= 30)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                }
                else if (typeGroup == "Business")
                {
                    if (numberPeople >= 100)
                    {
                        numberPeople -= 10;
                    }
                    totalPrice = numberPeople * 15.60;
                }
                else if (typeGroup == "Regular")
                {
                    totalPrice = numberPeople * 20;
                    if (numberPeople >= 10 && numberPeople <= 20)
                    {
                        totalPrice -= totalPrice * 0.05;
                    }
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                if (typeGroup == "Students")
                {
                    totalPrice = numberPeople * 10.46;
                    if (numberPeople >= 30)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                }
                else if (typeGroup == "Business")
                {
                    if (numberPeople >= 100)
                    {
                        numberPeople -= 10;
                    }
                    totalPrice = numberPeople * 16;
                }
                else if (typeGroup == "Regular")
                {
                    totalPrice = numberPeople * 22.50;
                    if (numberPeople >= 10 && numberPeople <= 20)
                    {
                        totalPrice -= totalPrice * 0.05;
                    }
                }
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
