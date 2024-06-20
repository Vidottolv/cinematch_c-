using Microsoft.EntityFrameworkCore;
using cinematch_back.Models;
using cinematch_back.Data.Map;

namespace cinematch_back.Data
{
    public class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options) 
        { 
        
        }

        public DbSet<TestModel> TBLTestes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TestMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
