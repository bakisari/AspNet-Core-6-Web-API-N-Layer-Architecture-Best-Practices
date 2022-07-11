using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    id = 1,
                    CategoryId = 1,
                    Price = 100,
                    Stock = 65,
                    CreateDate = DateTime.Now,
                    Name = "Faber Castel"
                    
                },
                new Product
                {
                    id = 2,
                    CategoryId = 2,
                    Price = 16,
                    Stock = 145,
                    CreateDate = DateTime.Now,
                    Name = "Kareli Defter"

                },
                new Product
                {
                    id = 3,
                    CategoryId = 3,
                    Name = "Son On Saniye",
                    Stock = 50,
                    CreateDate = DateTime.Now,
                    Price = 12
                });
        }
    }
}
