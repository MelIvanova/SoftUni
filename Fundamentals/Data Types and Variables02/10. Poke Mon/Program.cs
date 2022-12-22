using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerStart = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int pokedNum = 0;
            int pokePowerCurr = pokePowerStart;


            do
            {
                pokePowerCurr -= distance;
                pokedNum++;
                if ((pokePowerStart / 2) == pokePowerCurr && exhaustion!=0)
                {
                   pokePowerCurr = pokePowerCurr / exhaustion;
                }
            } while (pokePowerCurr >= distance);

            Console.WriteLine(pokePowerCurr);
            Console.WriteLine(pokedNum);
        }
    }
}
