
using NetTopologySuite.Geometries;

namespace EFCoreMovies.Entities
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Point location { get; set; }
        public CinemaOffer cinemaOffer { get; set; }

        public List<CinemaHall> cinemaHalls { get; set; }

    }
}
