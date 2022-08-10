using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WashClothes.Domain;

namespace WashClothes.Infra
{
    public class CothesDBContext : DbContext
    {
        public CothesDBContext(DbContextOptions<CothesDBContext> options) : base(options)
        {

        }

        public CothesDBContext()
        {

        }

        public DbSet<Clothes> Clothes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //this is necessary, because EF Core, doesn`t have the method "Conventions"
            //that we use to make the configuration of the tables
            modelBuilder.Entity<Clothes>(b =>
            {
                b.HasKey(p => p.Id);
                b.Property(p => p.Color).IsRequired();
            });

            modelBuilder.Entity<User>(b =>
            {
                b.HasMany(p => p.Clothes).WithOne().OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Seed();
        }
    }
}
