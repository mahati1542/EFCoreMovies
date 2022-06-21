namespace EFCoreMovies.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool inCinemas { get; set; }
        public DateTime releaseDate { get; set; }
        public string posterURL { get; set; }

        public List<Genre> genres { get; set; }
        public List<CinemaHall> cinemaHall { get; set; }

        public List<MoviesActor> movieActors { get; set; }


    }
}
