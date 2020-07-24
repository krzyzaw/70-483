using System;
using System.Diagnostics;

namespace SecurityAndDebug.ApplicationDeb
{
    public class MusicTrack
    {
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
#if DIAGNOSTIC
            Console.WriteLine($"Music track created: {this}");
#endif
        }
    }
}