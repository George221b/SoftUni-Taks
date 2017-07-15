using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.OnlineRadioDatabase
{
    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var album = new HashSet<Song>();

            for (int i = 0; i < n; i++)
            {
                try
                {
                    var inputLine = Console.ReadLine().Split(';');
                    var artist = inputLine[0];
                    var songName = inputLine[1];
                    var length = inputLine[2].Split(':').Select(x => x.Trim()).ToArray();
                    var minutes = int.Parse(length[0]);
                    var seconds = int.Parse(length[1]);

                    var song = new Song(artist, songName, minutes, seconds);
                    Console.WriteLine("Song added.");
                    album.Add(song);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            Console.WriteLine($"Songs added: {album.Count}");

            var totalSeconds = 0;
            foreach (var song in album)
            {
                totalSeconds += song.Seconds + (60 * song.Minutes);
            }

            DateTime albumLength = new DateTime().AddSeconds(totalSeconds);
            string format = "H m s";
            var totalLength = albumLength.ToString(format).Split();
            Console.WriteLine($"Playlist length: {totalLength[0]}h {totalLength[1]}m {totalLength[2]}s");
        }
    }
}
