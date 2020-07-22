using System.Linq;
using MusicStore.Data;

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
            var musicTracks = _context.MusicTrack.ToList();
            //var musicTracks = new IEnumerable<MusicTrack>().ToList();

            //IEnumerable<MusicTrack> selectedTracks = from track in musicTracks where track.ArtistId == 5 select track;
        }
    }
}