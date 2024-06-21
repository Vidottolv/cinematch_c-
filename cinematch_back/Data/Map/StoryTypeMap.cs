using cinematch_back.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace cinematch_back.Data.Map
{
    public class StoryTypeMap : IEntityTypeConfiguration<StoryTypeModel>
    {
        public void Configure(EntityTypeBuilder<StoryTypeModel> builder)
        {
            builder.HasKey(x => x.IDStoryType);
            builder.Property(x => x.StoryType).HasMaxLength(255);
        }
    }
}
