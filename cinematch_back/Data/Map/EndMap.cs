using cinematch_back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cinematch_back.Data.Map
{
    internal class EndMap : IEntityTypeConfiguration<EndModel>
    {
        public void Configure(EntityTypeBuilder<EndModel> builder) 
        {
            builder.HasKey(x => x.IDEnd);
            builder.Property(x => x.End).HasMaxLength(255);
        }

    }
}