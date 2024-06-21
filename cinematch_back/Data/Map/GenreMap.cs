using cinematch_back.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace cinematch_back.Data.Map
{
    public class GenreMap : IEntityTypeConfiguration<GenreModel>
    {
        public void Configure(EntityTypeBuilder<GenreModel> builder)
        {
            builder.HasKey(x => x.IDGenre);
            builder.Property(x => x.Genre).HasMaxLength(255);
        }
    }
}
