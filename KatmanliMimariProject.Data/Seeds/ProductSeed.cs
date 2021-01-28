﻿using KatmanliMimariProject.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliMimariProject.Data.Seeds
{
    class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Pilot Kalem", Price = 12.50m, Stock = 100, CategoryId = _ids[0] },
                new Product { Id = 2, Name = "Kurşun Kalem", Price = 40.50m, Stock = 200, CategoryId = _ids[0] },
                new Product { Id = 3, Name = "Tükenmez Kalem", Price = 500.10m, Stock = 300, CategoryId = _ids[0] },
                new Product { Id = 4, Name = "Küçük Boy Defter", Price = 300, Stock = 300, CategoryId = _ids[1] },
                new Product { Id = 5, Name = "Orta Boy Defter", Price = 450, Stock = 155, CategoryId = _ids[1] },
                new Product { Id = 6, Name = "Büyük Boy Defter", Price = 500, Stock = 180, CategoryId = _ids[1] }
            );
        }
    }
}
