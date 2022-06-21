using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreMovies.Entities.Configurations
{
    public class MovieActorConfig : IEntityTypeConfiguration<MoviesActor>
    {
        public void Configure(EntityTypeBuilder<MoviesActor> builder)
        {
            builder.HasKey(p => new { p.movieId, p.actorId });
            builder.Property(p => p.character).HasMaxLength(150);
        }
    }
}
