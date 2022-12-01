using System;

namespace _09._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHouer = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int entringHouer = int.Parse(Console.ReadLine());
            int enteringMinutes = int.Parse(Console.ReadLine());

            if(examHouer==entringHouer && examMinutes==enteringMinutes)
            {
                Console.WriteLine("On time");
            }
           
            int examAllMin = examHouer * 60 + examMinutes;
            int enteringAllMin = entringHouer * 60 + enteringMinutes;
            int diference = 0;
            if (enteringAllMin > examAllMin)
            {
                diference = enteringAllMin - examAllMin;
                Console.WriteLine("Late");
                int diferenceHouer = diference / 60;
                int diferenceMinutes = diference % 60;
                if (diferenceMinutes >= 0 && diferenceMinutes <= 59 && diferenceHouer == 0)
                {
                    Console.WriteLine($"{diferenceMinutes} minutes after the start");
                }
                else if (diferenceHouer >= 1 && diferenceHouer <= 23)
                {
                    Console.WriteLine($"{diferenceHouer}:{diferenceMinutes:D2} hours after the start");
                }
            }
            else if (examAllMin > enteringAllMin && enteringAllMin >= (examAllMin - 30))
            {
                diference = examAllMin-enteringAllMin;
                Console.WriteLine("On time");
                int diferenceHouer = diference / 60;
                int diferenceMinutes = diference % 60;
                if (diferenceMinutes >= 0 && diferenceMinutes <= 59 && diferenceHouer == 0)
                {
                    Console.WriteLine($"{diferenceMinutes} minutes before the start");
                }
                else if (diferenceHouer >= 1 && diferenceHouer <= 23)
                {
                    Console.WriteLine($"{diferenceHouer}:{diferenceMinutes:D2} hours before the start");
                }
            }
            else if(enteringAllMin < (examAllMin - 30))
            {
                diference = examAllMin - enteringAllMin ;
                Console.WriteLine("Early");
                int diferenceHouer = diference / 60;
                int diferenceMinutes = diference % 60;
                if (diferenceMinutes >= 0 && diferenceMinutes <= 59 && diferenceHouer == 0)
                {
                    Console.WriteLine($"{diferenceMinutes:D2} minutes before the start");
                }
                else if (diferenceHouer >= 1 && diferenceHouer <= 23)
                {
                    Console.WriteLine($"{diferenceHouer}:{diferenceMinutes:D2} hours before the start");
                }
            }
            
        }

    }
}
