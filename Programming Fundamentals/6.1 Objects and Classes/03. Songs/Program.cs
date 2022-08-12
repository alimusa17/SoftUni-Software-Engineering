using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();

            int songCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < songCount; i++)
            {
                string[] songProperties = Console.ReadLine().Split('_');

                Song song = new Song(songProperties[0], songProperties[1], songProperties[2]);

                songs.Add(song);
            }

            string typelist = Console.ReadLine();

            if (typelist == "all")
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
                    if (song.TypeList == typelist)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    class Song
    {
        public Song(string typelist, string name, string time)
        {
            this.TypeList = typelist;
            this.Name = name;
            this.Time = Time;
        }

        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }


    }
}
