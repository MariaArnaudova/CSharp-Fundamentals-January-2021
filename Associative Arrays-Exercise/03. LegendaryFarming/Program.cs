using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            SortedDictionary<string, int> materialsCount = new SortedDictionary<string, int>();
            //materialsCount.Add("shards", 0);
            //materialsCount.Add("fragments", 0);
            //materialsCount.Add("motes", 0);

            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();

            string material = "";
            int countObtained = 0;
            bool isOver = false;

            while (true)
            {

                for (int i = 0; i < input.Length; i++)
                {

                    if (i % 2 == 0)
                    {
                        countObtained = int.Parse(input[i]);
                        continue;
                    }
                    else
                    {
                        material = input[i].ToLowerInvariant();
                    }

                    if (material != "shards" && material != "fragments" && material != "motes")
                    {

                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, countObtained);
                        }
                        else
                        {
                            junk[material] += countObtained;
                        }
                    }
                    else
                    {

                        if (!materialsCount.ContainsKey(material))
                        {

                            if (countObtained > 250)
                            {

                                int lastCount = countObtained - 250;
                                materialsCount.Add(material, lastCount);

                                if (material == "shards")
                                {
                                    Console.WriteLine($"Shadowmourne obtained!");
                                    isOver = true;
                                    break;
                                }
                                else if (material == "fragments")
                                {
                                    Console.WriteLine($"Valanyr obtained!");
                                    isOver = true;
                                    break;
                                }
                                else if (material == "motes")
                                {
                                    Console.WriteLine($"Dragonwrath  obtained!");
                                    isOver = true;
                                    break;
                                }

                            }
                            else
                            {
                                materialsCount.Add(material, countObtained);
                            }
                        }
                        else
                        {
                            materialsCount[material] += countObtained;

                            if (materialsCount[material] > 250)
                            {

                                int lastCount = countObtained - 250;
                                materialsCount[material] += lastCount;

                                if (material == "shards")
                                {
                                    Console.WriteLine($"Shadowmourne obtained!");
                                    isOver = true;
                                    break;
                                }
                                else if (material == "fragments")
                                {
                                    Console.WriteLine($"Valanyr obtained!");
                                    isOver = true;
                                    break;
                                }
                                else if (material == "motes")
                                {
                                    Console.WriteLine($"Dragonwrath  obtained!");
                                    isOver = true;
                                    break;
                                }
                            }
                            //else
                            //{
                                
                            //}
                        }
                    }
                }

                if (isOver)
                {
                    break;
                }

                input = Console.ReadLine().Split();
            }

            Dictionary<string, int> orderByDecending = materialsCount
                                
                .OrderByDescending(m => m.Value)
                .OrderBy(m => m.Key)
                .ToDictionary(key => key.Key, value => value.Value);

            var orderJunk = junk
                .OrderBy(m => m.Key)
                .ToDictionary(key => key.Key, value => value.Value);

            foreach (var item in materialsCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
