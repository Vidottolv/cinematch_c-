using Microsoft.EntityFrameworkCore;
using cinematch_back.Models;
using cinematch_back.Data.Map;

namespace cinematch_back.Data
{
    public class GenreDBContext : DbContext
    {
        public GenreDBContext(DbContextOptions<GenreDBContext> options) : base(options) 
        { 
        
        }

        public DbSet<GenreModel> TBLGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GenreMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
