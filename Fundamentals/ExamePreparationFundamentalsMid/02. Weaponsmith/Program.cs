using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> weaponNameParts = Console.ReadLine().Split('|').ToList();
            string command = Console.ReadLine(); ;
            while (command != "Done")
            {
                string[] commands = command.Split();
                if (commands[1]=="Left")
                {
                    int indexL = int.Parse(commands[2]);
                    if (indexL>0&&indexL<weaponNameParts.Count)
                    {
                        string temp = weaponNameParts[indexL];
                        weaponNameParts[indexL] = weaponNameParts[indexL - 1];
                        weaponNameParts[indexL -1] = temp;
                    }
                    
                }
                else if (commands[1] == "Right")
                {
                    int indexR = int.Parse(commands[2]);
                    if ((weaponNameParts.Count - 1) > (indexR))
                    {
                        string temp = weaponNameParts[indexR];
                        weaponNameParts[indexR] = weaponNameParts[indexR + 1];
                        weaponNameParts[indexR + 1] = temp;
                    }
                }
                else if (commands[1] == "Even")
                {
                    for (int i = 0; i < weaponNameParts.Count; i++)
                    {
                        if (i%2==0)
                        {
                            Console.Write(weaponNameParts[i] + " ");
                        }
                        
                    }
                    Console.WriteLine();
                }
                else if (commands[1] == "Odd")
                {
                    for (int i = 0; i < weaponNameParts.Count; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write(weaponNameParts[i] + " ");
                        }
                        
                    }
                    Console.WriteLine();

                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"You crafted {string.Join("", weaponNameParts)}!");

        }
    }
}
