using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Entities
{
    [Serializable]
    public class MusicTrack
    {
        public int Id { get; set; }

        public int ArtistId { get; set; }

        [ForeignKey("ArtistId")]
        public virtual Artist Artist { get; set; }

        public string Title { get; set; }

        public int Length { get; set; }
    }
}