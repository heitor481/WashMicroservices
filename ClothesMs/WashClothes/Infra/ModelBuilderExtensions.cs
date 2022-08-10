using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WashClothes.Domain;

namespace WashClothes.Infra
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clothes>().HasData(
                new Clothes { Id = 1, Color = "Red", Type = ClotheType.Jacket },
                new Clothes { Id = 2, Color = "Blue", Type = ClotheType.Shirt },
                new Clothes { Id = 3, Color = "Green", Type = ClotheType.TShirt }
            );
        }
    }
}
