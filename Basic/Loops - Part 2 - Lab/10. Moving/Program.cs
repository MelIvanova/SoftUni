using System;

namespace _10._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int wide = int.Parse(Console.ReadLine());
            int lenth = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            string boxes = Console.ReadLine();
            int roomSpase = wide*lenth*hight;
            int box = 0;
            int boxSpase = 0;
            while (boxes != "Done")
            {
                box = int.Parse(boxes);
                boxSpase += box;
                if (boxSpase>roomSpase)
                {
                    int diff = boxSpase - roomSpase;
                    Console.WriteLine($"No more free space! You need {diff} Cubic meters more.");
                    return;
                }
                boxes = Console.ReadLine();
            }
            int diffe = roomSpase - boxSpase;
            Console.WriteLine($"{diffe} Cubic meters left.");

        }
    }
}
