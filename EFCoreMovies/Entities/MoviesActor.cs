namespace EFCoreMovies.Entities
{
    public class MoviesActor
    {
        public int movieId { get; set; }
        public int actorId { get; set; }
        public string character { get; set; }

        public int order { get; set; }
        public Movie movie { get; set; }
        public Actor actor { get; set; }
    }
}
