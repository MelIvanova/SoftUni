using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int coince = 0;
            double changeInCoince = Math.Floor(change * 100);
            while (changeInCoince>0)
            {
                
                if (changeInCoince>=200)
                {
                    changeInCoince -= 200;
                    coince++;
                }
                else if (changeInCoince >= 100)
                {
                    changeInCoince -= 100;
                    coince++;
                }
                else if (changeInCoince >= 50)
                {
                    changeInCoince -= 50;
                    coince++;
                }
                else if (changeInCoince >= 20)
                {
                    changeInCoince -= 20;
                    coince++;
                }
                else if (changeInCoince >= 10)
                {
                    changeInCoince -= 10;
                    coince++;
                }
                else if (changeInCoince >= 5)
                {
                    changeInCoince -= 5;
                    coince++;
                }
                else if (changeInCoince >= 2)
                {
                    changeInCoince -= 2;
                    coince++;
                }
                else if (changeInCoince >= 1)
                {
                    changeInCoince -= 1;
                    coince++;
                }
            }
            Console.WriteLine(coince);
        }
    }
}
