using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //The input data should be read from the console.It will consist of exactly 5 lines:
            //The amount of money Ivan Cho has – floating - point number in range[0.00…1, 000.00]
            //The count of students – integer in range[0…100]
            //The price of lightsabers for a single sabre – floating - point number in range[0.00…100.00]
            //The price of robes for a single robe – floating - point number in range[0.00…100.00]
            //The price of belts for a single belt – floating - point number in range[0.00…100.00]
            //The input data will always be valid.There is no need to check it explicitly.

            double amount = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelsts = double.Parse(Console.ReadLine());

            //int countFreeBells = 0; // *S if dava 40 / 100*/

            //if (countStudents >= 6)
            //{
            //    for (int i = 0; i < countStudents; i += 6)
            //    {
            //        countFreeBells++;
            //    }
            //}


            double allLightSabresPrice = countStudents * priceLightsabers + Math.Ceiling(countStudents * 0.10) * priceLightsabers;
            double allRobesPrice = countStudents * priceRobes;
            double allBelsPrice = (countStudents - countStudents / 6) * priceBelsts;
            //double allBelsPrice = (countStudents - countFreeBells) * priceBelsts;

            double priceAllEquipment = allLightSabresPrice + allRobesPrice + allBelsPrice;

            if (priceAllEquipment <= amount)
            {
                Console.WriteLine($"The money is enough - it would cost {priceAllEquipment:F2}lv.");
            }
            else if (priceAllEquipment > amount)
            {
                Console.WriteLine($"Ivan Cho will need {(priceAllEquipment - amount):F2}lv more.");
            }
        }
    }
}
