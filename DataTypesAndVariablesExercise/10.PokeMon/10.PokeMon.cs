using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int distancePokTargetsM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());

            int substractFromN = pokePowerN;
            int countTargetPoke = 0;

            while (substractFromN >= distancePokTargetsM)
            {

                if (substractFromN == pokePowerN / 2)
                {
                    if (exhaustionFactorY > 0)
                    {
                        substractFromN /= exhaustionFactorY;
                        continue;
                    }
                    if (substractFromN < distancePokTargetsM)
                    {
                        break;
                    }
                }
                countTargetPoke++;
                substractFromN -= distancePokTargetsM;
            }
            Console.WriteLine($"{substractFromN}");
            Console.WriteLine($"{countTargetPoke}");
        }
    }
}
