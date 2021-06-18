using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class ReactivitiesContext : DbContext
    {

        public DbSet<Activity> Activities { get; set; }
        
        
        public ReactivitiesContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}