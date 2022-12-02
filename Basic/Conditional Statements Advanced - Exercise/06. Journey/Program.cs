using System;

namespace _06._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – „Somewhere in [дестинация]“ измежду “Bulgaria", "Balkans” и ”Europe”
            //•	Втори ред – “{Вид почивка} – {Похарчена сума}“
            //o	Почивката може да е между „Camp” summer и „Hotel” winter

            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string settelsIn = "";
            double moneySpend = 0;
            if(buget<=100)
            {
                destination = "Bulgaria";
                if(season == "summer")
                {
                    moneySpend = buget * 0.30;
                    settelsIn = "Camp";
                }
                else if(season == "winter")
                {
                    moneySpend = buget * 0.70;
                    settelsIn = "Hotel";
                }
            }
            else if (buget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    moneySpend = buget * 0.40;
                    settelsIn = "Camp";
                }
                else if (season == "winter")
                {
                    moneySpend = buget * 0.80;
                    settelsIn = "Hotel";
                }
            }
           else if (buget > 1000)
            {
                destination = "Europe";
                if (season == "summer")
                {
                    moneySpend = buget * 0.90;
                    settelsIn = "Hotel";
                }
                else if (season == "winter")
                {
                    moneySpend = buget * 0.90;
                    settelsIn = "Hotel";
                }

            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{settelsIn} - {moneySpend:F2}");
        }
    }
}
