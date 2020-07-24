using System;

namespace SecurityAndDebug.ApplicationDebug
{
    public class MusicTrack
    {
        public static bool DebugMode = false;

        public string Artist { get; set; }

        public string Title { get; set; }

        public int Length { get; set; }

        public override string ToString()
            => $"Artist: {Artist}, Title: {Title}, Length: {Length}";

        public MusicTrack(string artist, string title, int length)
        {
            Artist = artist;
            Title = title;
            Length = length;
            if (DebugMode)
            {
                Console.WriteLine($"Music track created: {this}");
            }
        }
    }
}