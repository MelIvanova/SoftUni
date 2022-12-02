using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int i = 1;
            double sum = 0, greades = 0, final = 0;
            while (i<=12)
            {
                greades = double.Parse(Console.ReadLine());
               if(greades>=4)
                {
                    sum += greades;
                    final = sum / i;
                    i++;
                }
               else
                {
                    i += 0;
                }
                
            }
            
            if (final>=4)
            {
                Console.WriteLine($"{name} graduated. Average grade: {final:F2}");
            }
            
        }
    }
}
