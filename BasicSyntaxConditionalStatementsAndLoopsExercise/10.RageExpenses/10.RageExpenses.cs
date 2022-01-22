using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            // headset, mouse, keyboard and display
            // Every second lost game, Pesho trashes his headset
            // Every third lost game, Pesho trashes his mouse

            /*On the first input line - lost games count – integer in the range [0, 1000]*/
            /*On the second line – headset price -floating point number in range[0, 1000]*/
            //On the third line – mouse price -floating point number in range[0, 1000].
            /*On the fourth line – keyboard price -floating point number in range[0, 1000*/
            //On the fifth line – display price -floating point number in range[0, 1000].

            // Calculate his rage expenses for renewing his gaming equipment.

            int countLostGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keybbordPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int keyboardCount = 0;
            int display = 0;
           
            int headsetCount = countLostGame / 2;
            int mouseCount = countLostGame / 3;

            for (int i = 1; i <= countLostGame; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCount++;    
                }
            }
            display = keyboardCount / 2;

            double allTrashPrice = headsetCount * headsetPrice + mouseCount * mousePrice +
                                    keyboardCount * keybbordPrice + display * displayPrice;
            Console.WriteLine($"Rage expenses: {allTrashPrice:f2} lv.");
        }
    }
}
