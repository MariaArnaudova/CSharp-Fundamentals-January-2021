using System;

namespace _10.PokeMon_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int distancePokTargetsM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());

            int countTargetPoke = 0;
            double divisionIfEqual = pokePowerN * 0.5;

            while (pokePowerN >= distancePokTargetsM)
            {
                countTargetPoke++;
                pokePowerN -= distancePokTargetsM;

                if (pokePowerN==divisionIfEqual)
                {
                    if (exhaustionFactorY!=0)
                    {
                        pokePowerN /= exhaustionFactorY;
                    }
                }
            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(countTargetPoke);
        }
    }
}
