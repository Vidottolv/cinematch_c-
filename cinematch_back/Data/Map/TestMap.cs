using cinematch_back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cinematch_back.Data.Map
{
    public class TestMap : IEntityTypeConfiguration<TestModel>
    {
        public void Configure(EntityTypeBuilder<TestModel> builder) 
        {
            builder.HasKey(x => x.IDTest);
            builder.Property(x => x.Teste).HasMaxLength(255);

        } 
    }
}
