using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double volumeBig = 0;
            string bigger = "";

            for (int i = 0; i < count; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int hight = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * hight;

                if (volume > volumeBig)
                {
                    volumeBig = volume;
                    bigger = model;
                }
                
            }

            Console.WriteLine(bigger);
        }
    }
}
