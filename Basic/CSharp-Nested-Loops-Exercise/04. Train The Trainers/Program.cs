using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jurey = int.Parse(Console.ReadLine());
            string presentationName = "";
            double midGrades = 0;
            double allMid = 0;
            int counter = 0;
            while ((presentationName=Console.ReadLine()) != "Finish")
            {
                midGrades = 0;
                for (int i = 1; i <= jurey; i++)
                {
                    double greads = double.Parse(Console.ReadLine());
                    midGrades += greads;
                }
                midGrades = midGrades / jurey;
                allMid += midGrades;
                counter++;
                Console.WriteLine($"{presentationName} - {midGrades:F2}.");
            }
            allMid = allMid / counter;
            Console.WriteLine($"Student's final assessment is {allMid:F2}.");
        }
    }
}
