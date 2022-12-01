using System;

namespace HomeWork__01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectsNumber = int.Parse(Console.ReadLine());
            int projects = projectsNumber * 3;
            Console.WriteLine($"The architect {name} will need {projects} hours to complete {projectsNumber} project/s.");


        }
    }
}
