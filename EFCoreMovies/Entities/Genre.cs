namespace EFCoreMovies.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Movie> movies { get; set; }

    }
}
