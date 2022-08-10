using Drivers.Domain.Drivers;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Drivers.Infra
{
    public class DriversDBContext : DbContext
    {
        public DriversDBContext(DbContextOptions<DriversDBContext> options) : base(options)
        {

        }

        public DriversDBContext()
        {

        }

        public DbSet<Driver> Drivers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //this is necessary, because EF Core, doesn`t have the method "Conventions"
            //that we use to make the configuration of the tables
            modelBuilder.Entity<Driver>(b =>
            {
                b.HasKey(p => p.Id);
                b.Property(p => p.Name).IsRequired();
                b.Property(p => p.Surname).IsRequired();
            });

            modelBuilder.Seed();
        }
    }
}
