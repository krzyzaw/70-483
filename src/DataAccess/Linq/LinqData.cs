using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Entities;

namespace DataAccess.Linq
{
    public class LinqData
    {
        private readonly MusicStoreContext _context;

        public LinqData(MusicStoreContext context)
        {
            _context = context;
        }

        public void ReadData()
        {
            var musicTracks = _context.MusicTrack.Include(x => x.Artist).AsQueryable();

            var count = _context.MusicTrack.Include(x => x.Artist).Where(x => x.ArtistId == 5).Sum(x => x.Length);

            List<MusicTrack> musicTracks1 = _context.MusicTrack.Include(x => x.Artist).Where(y => y.ArtistId == 5).ToList();

            //basic linq operator
            IEnumerable<MusicTrack> selectedTracks = from track in musicTracks where track.ArtistId == 5 select track;

            //linq method chain
            IQueryable<MusicTrack> selectedTracksChain = musicTracks.Where(track => track.ArtistId == 5).AsQueryable();

            var tracks = selectedTracksChain.ToList();

            //use var
            var selectedTracksVar = musicTracks.Where(track => track.ArtistId == 5);

            //linq projection
            var selectedTrack = musicTracks.Where(track => track.Artist.Name == "Artist 1").Select(x =>
                new TrackDetails()
                {
                    ArtistName = x.Artist.Name,
                    Title = x.Title
                });

            //anonymous type
            var anonymousSelectedTracks = musicTracks.Where(track => track.Artist.Name == "Artist 1").Select(x =>
                new
                {
                    ArtistName = x.Artist.Name,
                    Title = x.Title
                });
        }

        public List<MusicTrack> LinqOperations()
        {
            var musicTracks = _context.MusicTrack.ToList();
            return musicTracks;

            var artists = _context.Artist.ToList();

            //linq join
            var artistTracks = from artist in artists
                               where artist.Name == "Artist 1"
                               join musicTrack in musicTracks on artist.Id equals musicTrack.ArtistId
                               select new
                               {
                                   ArtistName = artist.Name,
                                   musicTrack.Title
                               };

            //linq join method chain
            var artistTracksChain = artists.Where(artist => artist.Name == "Artist 1")
                .Join(musicTracks, artist => artist.Id, musicTrack => musicTrack.ArtistId,
                    (artist, musicTrack) => new { ArtistName = artist.Name, musicTrack.Title });

            //linq group
            var artistSummary = from track in musicTracks
                                join a in artists on track.ArtistId equals a.Id
                                group track by a.Name
                                                    into artistTrackSummary
                                select new
                                {
                                    Id = artistTrackSummary.Key,
                                    Count = artistTrackSummary.Count()
                                };

            //linq group chain
            var artistSummaryChain = musicTracks
                .Join(artists, track => track.ArtistId, a => a.Id, (track, a) => new { track, a })
                .GroupBy(@t => @t.a.Name, @t => @t.track)
                .Select(artistTrackSummary => new { Id = artistTrackSummary.Key, Count = artistTrackSummary.Count() });

            //linq take and skip
            int pageNo = 0;
            int pageSize = 5;

            var trackList = musicTracks.Skip(pageSize * pageNo).Take(pageSize);

            //linq aggregate
            var artSummary = from track in musicTracks
                             join artist in artists on track.ArtistId equals artist.Id
                             group track by artist.Name
                into artistTrackSummary
                             select new
                             {
                                 Id = artistTrackSummary.Key,
                                 Length = artistTrackSummary.Sum(x => x.Length)
                             };

            var nums = new[] { 1, 2, 3, 4 };
            var sum = nums.Aggregate((a, b) => a + b);
        }
    }

    public class TrackDetails
    {
        public string ArtistName { get; set; }

        public string Title { get; set; }
    }
}