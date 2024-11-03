using System;

namespace _05.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());

            byte numberOfLines = byte.Parse(Console.ReadLine());
            int currentValue = 0;
            string message = String.Empty;

            for (int i = 0; i < numberOfLines; i++)
            {
                char louerAndUpperCharacters = char.Parse(Console.ReadLine());
                currentValue = (int)louerAndUpperCharacters;
                int newCharValue = currentValue + key;
                message += (char)newCharValue;
            }
            Console.WriteLine(message);
        }
    }
}
