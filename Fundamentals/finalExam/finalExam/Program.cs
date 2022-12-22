using System;

namespace finalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string input = Console.ReadLine();

            while (input !="Generate")
            {
                string[] commandArgs = input.Split(">>>");
                string command = commandArgs[0];

                switch (command)
                {
                    case "Contains":
                        if (activationKey.Contains(commandArgs[1]))
                        {
                            Console.WriteLine($"{activationKey} contains {commandArgs[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        string upOrLow = commandArgs[1];
                        int start = int.Parse(commandArgs[2]);
                        int finfish = int.Parse(commandArgs[3]);
                        int end = finfish - start;
                        if (upOrLow== "Upper")
                        {
                            if (start==0)
                            {
                                activationKey = activationKey.Substring(start, end).ToUpper()
                                    +activationKey.Substring(finfish);
                            }
                            else
                            {
                                activationKey = activationKey.Substring(0,start)
                                    + activationKey.Substring(start, end).ToUpper() 
                                    + activationKey.Substring(finfish);
                            }
                        }
                        else if (upOrLow== "Lower")
                        {
                            if (start == 0)
                            {
                                activationKey = activationKey.Substring(start, end).ToLower()
                                    + activationKey.Substring(finfish);
                            }
                            else
                            {
                                activationKey = activationKey.Substring(0, start) 
                                    + activationKey.Substring(start, end).ToLower()
                                    + activationKey.Substring(finfish);
                            }
                        }
                        Console.WriteLine(activationKey);
                        break;
                    case "Slice":
                        int begining = int.Parse(commandArgs[1]);
                        int ends = int.Parse(commandArgs[2]);
                        int length = ends - begining;
                        activationKey = activationKey.Remove(begining, length);
                        Console.WriteLine(activationKey);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
