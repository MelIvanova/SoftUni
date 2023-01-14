using System;

namespace CustomTuple
{
   public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            string fullName = $"{input[0]} {input[1]}";
            string countrey = input[3];
            if (input.Length > 4)
            {
                for (int i = 4; i < input.Length; i++)
                {
                    countrey += $" {input[i]}";
                }
            }

            Threeuple<string, string, string> addres =
                new Threeuple<string, string, string>(fullName, input[2], countrey);
            Console.WriteLine(addres);

            string[] secondInput = Console.ReadLine().Split(" ");

            bool drunk = secondInput[2] == "drunk" ? true : false;

            Threeuple<string, int, bool> drunkPerson = 
                new Threeuple<string, int, bool>(secondInput[0], int.Parse(secondInput[1]), drunk);

            Console.WriteLine(drunkPerson);

            string[] thirdInput = Console.ReadLine().Split(" ");

            Threeuple<string, double, string> accout =
               new Threeuple<string, double, string>(thirdInput[0], double.Parse(thirdInput[1]), thirdInput[2]);

            Console.WriteLine(accout);

            /*string[] input = Console.ReadLine().Split(" ");
            MyTupe<string, string> first = new MyTupe<string, string>(input[0]+" "+ input[1], input[2]);
            Console.WriteLine(first.ToString());

            string[] input2 = Console.ReadLine().Split(" ");
            MyTupe<string, int> second = new MyTupe<string, int>(input2[0] , int.Parse(input2[1]));
            Console.WriteLine(second.ToString());

            string[] input3 = Console.ReadLine().Split(" ");
            MyTupe<int, double> third = new MyTupe<int, double>(int.Parse(input3[0]), double.Parse(input3[1]));
            Console.WriteLine(third.ToString());*/
        }
    }
}
