using System;
using System.Collections.Generic;

namespace _02._AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();

            Dictionary<string, int> resourcesCount = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());


                if (!resourcesCount.ContainsKey(resource))
                {
                    resourcesCount.Add(resource, quantity);
                }
                else
                {
                    resourcesCount[resource] += quantity;
                }

                resource = Console.ReadLine();
            }

            foreach (var item in resourcesCount)
            {
                string currResource = item.Key;
                int resourceQuantity = item.Value;

                Console.WriteLine($"{currResource} -> {resourceQuantity}");
            }
        }
    }
}
