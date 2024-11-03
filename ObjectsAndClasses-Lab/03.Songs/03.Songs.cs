using System;
using System.Collections.Generic;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSongs = int.Parse(Console.ReadLine());

            List<Song> manySongs = new List<Song>();

            for (int i = 0; i < numberSongs; i++)
            {
                string[] titleSong = Console.ReadLine().Split('_');

                string type = titleSong[0];
                string name = titleSong[1];
                string time = titleSong[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                manySongs.Add(song);

            }
            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in manySongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in manySongs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }

            }

        }
    }
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
