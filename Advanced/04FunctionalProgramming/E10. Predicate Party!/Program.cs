using System;
using System.Collections.Generic;
using System.Linq;

namespace E10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string[] input = Console.ReadLine().Split();
            string command = input[0];
           
            Func<List<string>, string, string, List<string>> rereadList = (l, c, p) =>
            {
                List<string> partiList = new List<string>();
                switch (c)
                {
                    case "StartsWith":
                        for (int i = 0; i < l.Count; i++)
                        {
                            if (l[i].Substring(0,p.Length)==p)
                            {
                                partiList.Add(l[i]);
                            }
                        }
                        break;
                    case "EndsWith":
                        for (int i = 0; i < l.Count; i++)
                        {
                            if (l[i].Substring(l[i].Length-p.Length, l[i].Length-1) == p)
                            {
                                partiList.Add(l[i]);
                            }
                        }
                        break;
                    case "Length":
                        int lngth = int.Parse(p);
                        for (int i = 0; i < l.Count; i++)
                        {
                            if (l[i].Length==lngth)
                            {
                                partiList.Add(l[i]);
                            }
                        }
                        break;
                }

                return partiList;
            };


            while (command != "Party!")
            {
                string ctiteria = input[1];
                string parameter = input[2];
                if (command == "Double")
                {
                    List<string> doubleThem = rereadList(names, ctiteria,parameter);
                    for (int i = 0; i < names.Count; i++)
                    {
                        for (int j = 0; j < doubleThem.Count; j++)
                        {
                            if (names[i]==doubleThem[j])
                            {
                                names.Insert(i, doubleThem[j]);
                                i+=2;
                            }
                        }
                    }
                }
                else if (command == "Remove")
                {
                    List<string> removeThem = rereadList(names, ctiteria, parameter);
                    
                    for (int i = 0; i < names.Count; i++)
                    {
                        for (int j = 0; j < removeThem.Count; j++)
                        {
                            if (names[i] == removeThem[j])
                            {
                                names.Remove(removeThem[j]);
                                i--;
                            }
                        }
                    }
                }

                input = Console.ReadLine().Split();
                command = input[0];
            }

            if (names.Count>0)
            {
                Console.WriteLine(String.Join(", ",names)+ " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
