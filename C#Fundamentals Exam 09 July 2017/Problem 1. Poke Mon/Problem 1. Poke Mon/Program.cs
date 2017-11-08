using System;


class Program
{
    static void Main(string[] args)
    {
        int pokePower = int.Parse(Console.ReadLine());
        int distanceBetweenTargets = int.Parse(Console.ReadLine());
        int exhaustionFactor = int.Parse(Console.ReadLine());
        int halfPokePower = -1;

        if ((pokePower % 2) == 0)
        {
            halfPokePower = pokePower / 2;
        }

        int pokeCounter = 0;

        for (int i = pokePower; i >= 0 ; i-= distanceBetweenTargets)
        {
            if (i == halfPokePower && exhaustionFactor != 0)
            {
                i /= exhaustionFactor;
            }
            if ((i - distanceBetweenTargets) >= 0)
            {
                pokeCounter++;
            }
            pokePower = i;

        }

        Console.WriteLine(pokePower);
        Console.WriteLine(pokeCounter);

    }
}

