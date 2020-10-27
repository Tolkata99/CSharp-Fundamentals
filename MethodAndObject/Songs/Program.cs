using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSong = int.Parse(Console.ReadLine());

            List<song> songs = new List<song>();

            for (int i = 0; i < numSong; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                string type = data[0];
                string name = data[1];
                string time = data[2];

                song song = new song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;
            }
            string TypeList = Console.ReadLine();

            if(TypeList == "all")
            {
                foreach (song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (song song in songs)
                {
                    if(song.TypeList == TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

            List<Song> filteredSongs = songs
                .Where(s => s.TypeList >= typeList)
                .ToList();

            foreach (song song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}
