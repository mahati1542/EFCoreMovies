namespace EFCoreMovies.Entities
{
    public class CinemaHall
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public int CinemaId { get; set; }

        public Cinema cinema { get; set; }

        public CinemaHallType cinemaHallType { get; set; }

        public List<Movie> movies { get; set; }

    }
}
