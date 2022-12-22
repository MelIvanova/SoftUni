using System;
using System.Collections.Generic;
using System.Linq;

namespace _03ThirdTack
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> usersSendResived = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();

            while (input!="Statistics")
            {
                string[] argumets = input.Split('=',StringSplitOptions.RemoveEmptyEntries);
                string command = argumets[0];

                switch (command)
                {
                    case"Add":
                        string username = argumets[1];
                        int send = int.Parse(argumets[2]);
                        int resived = int.Parse(argumets[3]);
                        if (!usersSendResived.ContainsKey(username))
                        {
                            usersSendResived[username] = new List<int> { send, resived };
                        }
                        break;
                    case"Message":
                        string sender = argumets[1];
                        string resiver = argumets[2];
                        if (usersSendResived.ContainsKey(sender) && usersSendResived.ContainsKey(resiver))
                        {
                            usersSendResived[sender][0]++;
                            usersSendResived[resiver][1]++;
                        }
                        int messageCount = usersSendResived[sender][0] + usersSendResived[sender][1];
                        if (messageCount>=capacity)
                        {
                            usersSendResived.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        messageCount = usersSendResived[resiver][0] + usersSendResived[resiver][1];
                        if (messageCount>=capacity)
                        {
                            usersSendResived.Remove(resiver);
                            Console.WriteLine($"{resiver} reached the capacity!");
                        }
                        break;
                    case"Empty":
                        string user = argumets[1];
                        if (user == "All")
                        {
                            usersSendResived.Clear();
                        }
                        if (usersSendResived.ContainsKey(user))
                        {
                            usersSendResived.Remove(user);
                        }
                        break;
                }

                input = Console.ReadLine();
            
            }

            Console.WriteLine($"Users count: {usersSendResived.Count}");

            foreach (var user in usersSendResived.OrderByDescending(p=>p.Value[1]).ThenBy(p=>p.Key))
            {
                int count = user.Value[0] + user.Value[1];
                Console.WriteLine($"{user.Key} - {count}");
            }
        }
    }
}
