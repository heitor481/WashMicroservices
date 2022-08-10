using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WashClothes.Domain;

namespace WashClothes.Infra
{
	public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "Test", FullName = "Test", Age = 30 }
            );

            var clothes = new List<Clothes>()
            {
                new Clothes { Id = 1, Color = "Red", Type = ClotheType.Jacket, UserId = 1 },
                new Clothes { Id = 2, Color = "Blue", Type = ClotheType.Shirt, UserId = 1 },
                new Clothes { Id = 3, Color = "Green", Type = ClotheType.TShirt, UserId = 1 }
            };

            modelBuilder.Entity<Clothes>().HasData(clothes);
        }
    }
}
