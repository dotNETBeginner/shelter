using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_6_
{
    class Song
    {
        public string ArtistName { get; set; }
        public string SongName { get; set; }
        public int SongMinutes { get; set; }
        public int SongSeconds { get; set; }

        public Song(string artistName, string songName, int songMinutes, int songSeconds)
        {
            if ((artistName.Length < 3 || artistName.Length > 20) && (songName.Length < 3 || songName.Length > 30) &&
            (songMinutes > 14 && songSeconds > 59))
            { throw new InvalidSongException("Invalid song"); }

            else if (artistName.Length < 3 || artistName.Length > 20)
            { throw new InvalidArtistNameException("Artist name should be between 3 and 20 symbols"); }

            else if (songName.Length < 3 || songName.Length > 30)
            { throw new InvalidSongNameException("Song name should be between 3 and 30 symbols"); }

            else if (songMinutes > 14 && songSeconds > 59)
            { throw new InvalidSongLenghtException("Invalid song lenght"); }

            else if (songMinutes > 14)
            { throw new InvalidSongMinutesException("Song minutes should be between 0 and 14"); }

            else if (songSeconds > 59)
            { throw new InvalidSongSecondsException("Song seconds should be between 0 and 59"); }

            else
            {
                ArtistName = artistName;
                SongName = songName;
                SongMinutes = songMinutes;
                SongSeconds = songSeconds;
            }
        }
    }
}
