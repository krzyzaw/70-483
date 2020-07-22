using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicStore.Entities;

namespace MusicStore.Data
{
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext (DbContextOptions<MusicStoreContext> options)
            : base(options)
        {
        }

        public DbSet<MusicStore.Entities.MusicTrack> MusicTrack { get; set; }
    }
}
