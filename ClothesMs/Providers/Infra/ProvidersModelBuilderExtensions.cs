using Microsoft.EntityFrameworkCore;
using Providers.Domain;

namespace Providers.Infra
{
	public static class ProvidersModelBuilderExtensions
	{
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provider>().HasData(
                new Provider { Id = 1, Location = "Marco Bruto", Price = 200, Name = "Lavabo 1" },
                new Provider { Id = 2, Location = "juan pablo laguna", Price = 250, Name = "Lavabo 2" },
                new Provider { Id = 3, Location = "Test", Price = 300, Name = "Lavabo 3" }
            );
        }
    }
}
