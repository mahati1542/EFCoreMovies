using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreMovies.Entities.Configurations
{
    public class MoveConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(p => p.Title).HasMaxLength(150).IsRequired();
            builder.Property(p => p.releaseDate).HasColumnType("Date");
            builder.Property(p => p.posterURL).HasMaxLength(500).IsUnicode(false);
        }
    }
}
