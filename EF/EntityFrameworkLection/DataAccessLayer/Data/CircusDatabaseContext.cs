using DataAccessLayer.Entities;
using DataAccessLayer.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data
{
    public class CircusDatabaseContext : DbContext
    {
        public CircusDatabaseContext(DbContextOptions<CircusDatabaseContext> options) 
            : base(options) { }

        public DbSet<Clown> Clowns { get; set; }
        public DbSet<Toolbox> Toolboxes { get; set; }
        public DbSet<Circus> Circuses { get; set; }
        public DbSet<Owner> Owners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CircusConfiguration());
            modelBuilder.ApplyConfiguration(new ClownConfiguration());
            modelBuilder.ApplyConfiguration(new ToolboxConfiguration());
            modelBuilder.ApplyConfiguration(new OwnerConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
