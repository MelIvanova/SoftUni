using System;
using System.Linq;

namespace _602._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool noPepleLeft = false;
            bool noSpace = false;

            for (int i = 0; i < lift.Length; i++)
            {
                for (int j = lift[i]; j < 4; j++)
                {
                    lift[i]++;
                    people--;
                    if (people==0)
                    {
                        noPepleLeft = true;
                        if (lift[i]==4&&i==lift.Length-1)
                        {
                            noSpace = true;
                        }
                        break;
                    }
                }
                if (noPepleLeft)
                {
                    break;
                }
            }
            if (noPepleLeft&&!noSpace)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ",lift));
            }                
            else if (noPepleLeft&&noSpace)
            {
                Console.WriteLine(string.Join(" ", lift));
            }
            else
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }

        }
    }
}
