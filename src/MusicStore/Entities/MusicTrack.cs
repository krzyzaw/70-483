using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Entities
{
    public class MusicTrack
    {
        public int Id { get; set; }

        public int ArtistId { get; set; }

        [ForeignKey("ArtistId")]
        public virtual Artist Artist { get; set; }

        public string Title { get; set; }

        [Range(20,600)]
        public int Length { get; set; }
    }
}