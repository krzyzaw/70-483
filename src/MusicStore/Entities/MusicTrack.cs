using System.ComponentModel.DataAnnotations;

namespace MusicStore.Entities
{
    public class MusicTrack
    {
        public int Id { get; set; }

        public string Artist { get; set; }

        public string Title { get; set; }

        [Range(20,600)]
        public int Length { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}