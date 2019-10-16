using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_6_
{
    class RadioDataBase
    {
        public int Seconds { get; set; }
        public int Minutes { get; set; }
        public int Hours { get; set; }

        List<Song> someSongs = new List<Song>();

        public RadioDataBase() { }

        public void addSongInDataBase(int size, string artistName, string songName, int songMinutes, int songSeconds)
        {
                Song t = new Song(artistName, songName, songMinutes, songSeconds);
                someSongs.Add(t);
            
            Console.WriteLine("Song added");
        }

        public void DisplayStatus()
        {
            int countAddedSongs = 0;
            for (int i = 0; i < someSongs.Count; i++)
            {
                Minutes += someSongs[i].SongMinutes;
                Seconds += someSongs[i].SongSeconds;
                if (Seconds >= 60)
                {
                    Minutes++;
                    Seconds -= 60;
                }
                if (Minutes >= 60)
                {
                    Hours++;
                    Minutes -= 60;
                }
                countAddedSongs++;
            }

            Console.WriteLine($"Songs added: {countAddedSongs}\nPlaylist lenght: {Hours}h {Minutes}m {Seconds}s");
        }

        public void Display()
        {
            for(int i=0;i<someSongs.Count;i++)
            {
                Console.WriteLine($"{someSongs[i].ArtistName}  {someSongs[i].SongName}  {someSongs[i].SongMinutes}:{someSongs[i].SongSeconds}");
            }
        }
    }
}
