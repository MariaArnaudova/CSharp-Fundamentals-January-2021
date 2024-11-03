using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, int> materialsCount = new Dictionary<string, int>();
            materialsCount["shards"] = 0;
            materialsCount["fragments"] = 0;
            materialsCount["motes"] = 0;

            Dictionary<string, int> junk = new Dictionary<string, int>();

            //int countObtained = 0;
            bool isObtained = false;

            while (true)
            {

                string[] input = Console.ReadLine()
             .Split();

                for (int i = 0; i < input.Length; i += 2)
                {

                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "shards")
                    {
                      
                        materialsCount[material] += quantity;

                        if (materialsCount[material] >= 250)
                        {
                            materialsCount[material] = materialsCount[material] - 250;
                            Console.WriteLine($"Shadowmourne obtained!");
                            isObtained = true;
                            break;

                        }

                    }
                    else if (material == "fragments")
                    {
                        
                        materialsCount[material] += quantity;

                        if (materialsCount[material] >= 250)
                        {
                            materialsCount[material] = materialsCount[material] - 250;
                            Console.WriteLine($"Valanyr obtained!");
                            isObtained = true;
                            break;

                        }

                    }
                    else if (material == "motes")
                    {
                       
                        materialsCount[material] += quantity;

                        if (materialsCount[material] >= 250)
                        {
                            materialsCount[material] = materialsCount[material] - 250;
                            Console.WriteLine($"Dragonwrath obtained!");
                            isObtained = true;
                            break;

                        }
                    }
                    else
                    {

                        if (!junk.ContainsKey(material))
                        {
                            junk[material] = quantity;
                        }
                        else
                        {
                            junk[material] += quantity;
                        }
                    }
                }

                if (isObtained)
                {
                    break;
                }
            }

            materialsCount = materialsCount
                .OrderByDescending(m => m.Value)
                .ThenBy(m => m.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            junk = junk
                 .OrderBy(x => x.Key)
                 .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in materialsCount)
            {

                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junk)

            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }


        }
    }
}
