using System;
using System.Collections.Generic;

namespace WinSong
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSong = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numSong; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split("_", StringSplitOptions.RemoveEmptyEntries);
                string typeList = tokens[0];
                string name = tokens[1];
                string time = tokens[2];

                Song song = new Song();

                song.TypeList = typeList;
                song.Name = name;
                song.Time = time;

                songs.Add(song);



            }

            string comand = Console.ReadLine();
            if(comand == "All")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if(comand == song.TypeList)
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

        public string  Name { get; set; }

        public string  Time { get; set; }
    }
}
