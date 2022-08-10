using Microsoft.EntityFrameworkCore;
using Providers.Domain;
using System.Reflection;

namespace Providers.Infra
{
    public class ProvidersDBContext : DbContext
    {
        public ProvidersDBContext(DbContextOptions<ProvidersDBContext> options) : base(options)
        {

        }

        public ProvidersDBContext()
        {

        }

        public DbSet<Provider> Providers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //this is necessary, because EF Core, doesn`t have the method "Conventions"
            //that we use to make the configuration of the tables
            modelBuilder.Entity<Provider>(b =>
            {
                b.HasKey(p => p.Id);
                b.Property(p => p.Name).IsRequired();
            });

            modelBuilder.Seed();
        }
    }
}

