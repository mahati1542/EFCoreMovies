﻿using System.Reflection;
using EFCoreMovies.Entities;
using EFCoreMovies.Entities.Seeding;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovies
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            ModuleSeeding.Seed(modelBuilder);
        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }

        public DbSet<Cinema> Cinemas { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<CinemaOffer> CinemaOffers { get; set; }

        public DbSet<CinemaHall> cinemaHalls { get; set; }

        public DbSet<MoviesActor> movieActors { get; set; }
    }
}
