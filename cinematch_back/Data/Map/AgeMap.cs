using cinematch_back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cinematch_back.Data.Map
{
    public class AgeMap : IEntityTypeConfiguration<AgeModel>
    {
        public void Configure(EntityTypeBuilder<AgeModel> builder)
        {
            builder.HasKey(x => x.IDAge);
            builder.Property(x => x.Age).HasMaxLength(255);
        }
    }
}
