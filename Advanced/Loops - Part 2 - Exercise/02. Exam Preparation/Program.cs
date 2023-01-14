using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int faildProblems = int.Parse(Console.ReadLine());
            int faileds = 0, solvedProblemCoun = 0, greadSum = 0;
            string lastProblem = "";
            bool faild = true;
            while (faildProblems>faileds)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    faild = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade<=4)
                {
                    faileds++;
                }
                greadSum += grade;
                solvedProblemCoun++;
                lastProblem = problemName;

            }
            if (faild)
            {
                Console.WriteLine($"You need a break, {faildProblems} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {greadSum*1.0/solvedProblemCoun:F2}");
                Console.WriteLine($"Number of problems: {solvedProblemCoun}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
