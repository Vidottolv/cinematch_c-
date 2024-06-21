using Microsoft.EntityFrameworkCore;
using cinematch_back.Models;
using cinematch_back.Data.Map;

namespace cinematch_back.Data
{
    public class CinematchDBContext : DbContext
    {
        public CinematchDBContext(DbContextOptions<CinematchDBContext> options) : base(options) 
        { 
        
        }

        public DbSet<TestModel> TBLTestes { get; set; }
        public DbSet<GenreModel> TBLGenres { get; set; }
        public DbSet<StoryTypeModel> TBLStoryType { get; set; }
        public DbSet<AgeModel> TBLAge { get; set; }
        public DbSet<EndModel> TBLEnd { get;set; }
        public DbSet<KindModel> TBLKind { get; set; }
        public DbSet<DurationModel> TBLDurationMovie { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TestMap());
            modelBuilder.ApplyConfiguration(new GenreMap());
            modelBuilder.ApplyConfiguration(new StoryTypeMap());
            modelBuilder.ApplyConfiguration(new AgeMap());
            modelBuilder.ApplyConfiguration(new EndMap());
            modelBuilder.ApplyConfiguration(new KindMap());
            modelBuilder.ApplyConfiguration(new DurationMap());


            base.OnModelCreating(modelBuilder);
        }
    }
}
