using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Song> ListOfSongs = new List<Song>();
            int numberOfSongs = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split("_");

                Song song = new Song(input[0], input[1], input[2]);
                ListOfSongs.Add(song);


            }
            string typeOfTheList = Console.ReadLine();

            if (typeOfTheList == "all")
            {
                foreach (Song song in ListOfSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in ListOfSongs)
                {
                    if (song.TypeList == typeOfTheList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }

            }
        }



        class Song
        {

            public Song(string typeList, string name, string time)
            {
                TypeList = typeList;
                Name = name;
                Time = time;
            }
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}
