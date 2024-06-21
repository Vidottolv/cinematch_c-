using cinematch_back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cinematch_back.Data.Map
{
    internal class DurationMap : IEntityTypeConfiguration<DurationModel>
    {
        public void Configure(EntityTypeBuilder<DurationModel> builder) 
        {
            builder.HasKey(x => x.IDDuration);
            builder.Property(x => x.DurationMovie).HasMaxLength(255);
        }
    }
}