using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	"Facebook" -> 150 лв
            //•	"Instagram" -> 100 лв
            //•	"Reddit" -> 50 лв
            //"You have lost your salary." 

            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i = 1; i  <= tabs; i ++)
            {
                string name = Console.ReadLine();
                switch (name)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                if(salary<=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if(salary>0)
            {
                Console.WriteLine($"{salary}");
            }

        }
    }
}
