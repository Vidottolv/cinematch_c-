using cinematch_back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cinematch_back.Data.Map
{
    internal class KindMap : IEntityTypeConfiguration<KindModel>
    {
        public void Configure(EntityTypeBuilder<KindModel> builder)
        {
            builder.HasKey(x => x.IDKind);
            builder.Property(x => x.Kind).HasMaxLength(255);
        }
    }
}