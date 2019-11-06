﻿using BleemSync.Central.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BleemSync.Central.Data
{
    public class DatabaseContext : IdentityDbContext
    {
        public DbSet<Models.PlayStation.Art> PlayStation_Art { get; set; }
        public DbSet<Models.PlayStation.Disc> PlayStation_Discs { get; set; }
        public DbSet<Models.PlayStation.Game> PlayStation_Games { get; set; }
        public DbSet<Models.PlayStation.GameRevision> PlayStation_GameRevisions { get; set; }

        public DbSet<Models.MegaDrive.Art> MegaDrive_Art { get; set; }
        public DbSet<Models.MegaDrive.Cartridge> MegaDrive_Cartridges { get; set; }
        public DbSet<Models.MegaDrive.Game> MegaDrive_Games { get; set; }
        public DbSet<Models.MegaDrive.GameRevision> MegaDrive_GameRevisions { get; set; }

        public DbSet<GameGenre> Genres { get; set; }
        public DbSet<EsrbRatingDescriptor> EsrbRatingDescriptors { get; set; }
        public DbSet<PegiRatingDescriptor> PegiRatingDescriptors { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        private static bool _created = false;

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            if (!_created)
            {
                Database.Migrate();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
