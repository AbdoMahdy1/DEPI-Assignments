using System;
using E_commerce.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_commerce.Configuration
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> P)
        {
            P.ToTable("Products");

            P.HasKey(P => P.Id);

            P.Property(P => P.Id)
                .UseIdentityColumn(1, 1);

            P.Property(P => P.Name)
                .HasColumnType("varchar")
                .HasColumnName("ProductName")
                .HasMaxLength(50);

            P.Property(P => P.Price)
                .HasColumnType("money")
                .HasColumnName("ProductPrice")
                .HasMaxLength(50);

            P.HasMany(P => P.ProductOrders)
                .WithOne(PO => PO.Product)
                .HasForeignKey(PO => PO.ProductID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
