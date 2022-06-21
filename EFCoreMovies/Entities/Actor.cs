﻿namespace EFCoreMovies.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Biography { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public List<MoviesActor> movieActor { get; set; }


    }
}
