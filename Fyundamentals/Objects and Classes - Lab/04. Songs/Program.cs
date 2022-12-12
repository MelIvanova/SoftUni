using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
   

    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 1; i <= count; i++)
            {
                string[] input = Console.ReadLine().Split('_');

                string tipeList = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song();
                song.TipeList = tipeList;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string targetListTipe = Console.ReadLine();
            if (targetListTipe=="all")
            {
                foreach (var currentSong in songs)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }
            else
            {
                songs = songs.FindAll(x => x.TipeList == targetListTipe);
                foreach (var currentSong in songs)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }

            //1 else
            foreach (Song currentSong in songs)
            {
                if (currentSong.TipeList == targetListTipe)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }

            //2 else
            songs = songs.FindAll(x => x.TipeList == targetListTipe);
            foreach (var currentSong in songs)
            {
                Console.WriteLine(currentSong.Name);
            }

            //3 else
            songs.Where(x => x.TipeList == targetListTipe).ToList().ForEach(x => Console.WriteLine(x.Name));
        }
    }
}
