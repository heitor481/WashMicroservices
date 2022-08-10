using Drivers.Domain.Drivers;
using Microsoft.EntityFrameworkCore;

namespace Drivers.Infra
{
	public static class DriversModelBuilderExtensions
	{
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Driver>().HasData(
                new Driver { Id = 1, Surname = "Ribeiro", Name = "Hunter" },
                new Driver { Id = 2, Surname = "Ribeiro", Name = "Dante" },
                new Driver { Id = 3, Surname = "Ribeiro", Name = "Test" }
            );
        }
    }
}
