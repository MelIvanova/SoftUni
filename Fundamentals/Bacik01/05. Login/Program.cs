using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length-1; i >= 0; i--)
            {
                
                password = password + username[i];
            }
            for (int i = 0; i < 4; i++)
            {
                string enterPassword = Console.ReadLine();
                
                if(password == enterPassword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if(i == 3)
                {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

            }
        }
    }
}
