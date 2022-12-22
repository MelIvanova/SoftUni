using System;

namespace _401._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());
            int attendancesCount = 0;
            double totoalStudentBonus = 0;
            double bigestBonus = 0;
            double attendanceBest = 0;

            for (int i = 0; i < students; i++)
            {
                attendancesCount = int.Parse(Console.ReadLine());
                totoalStudentBonus = (attendancesCount * 1.00 / lectures) * (5 + initialBonus);
                if (totoalStudentBonus>bigestBonus)
                {
                    bigestBonus = totoalStudentBonus;
                    attendanceBest = attendancesCount;
                }  
            }

            Console.WriteLine($"Max Bonus: {Math.Round(bigestBonus)}.");
            Console.WriteLine($"The student has attended {attendanceBest} lectures.");
        }
    }
}
