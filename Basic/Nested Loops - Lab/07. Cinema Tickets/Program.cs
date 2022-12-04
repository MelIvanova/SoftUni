using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            int totalTickets = 0;
            int studentTicket = 0;
            int standardTicket = 0;
            int kidTicket = 0;
            while (filmName!= "Finish")
            {
                int freeeSeads = int.Parse(Console.ReadLine());
                string ticket = Console.ReadLine();
                int counter = 0;
                while (ticket!= "End")
                {
                    switch (ticket)
                    {
                        case "student":
                            studentTicket++;
                            break;
                        case "standard":
                            standardTicket++;
                            break;
                        case "kid":
                            kidTicket++;
                            break;

                    }
                    counter++;
                    if (counter==freeeSeads)
                    {
                        break;
                    }
                    ticket = Console.ReadLine();
                }
                totalTickets += counter;
                double seadsTaken = counter*1.0 / freeeSeads * 100;
                Console.WriteLine($"{filmName} - {seadsTaken:F2}% full.");
                filmName = Console.ReadLine();
            }
            double studentTicketPercent = studentTicket * 1.0 / totalTickets * 100;
            double standardTicketPercent = standardTicket * 1.0 / totalTickets * 100;
            double kidTicketPercent = kidTicket * 1.0 / totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{ studentTicketPercent:F2}% student tickets.");
            Console.WriteLine($"{standardTicketPercent:F2}% standard tickets.");
            Console.WriteLine($"{kidTicketPercent:F2}% kids tickets.");
        }
    }
}
