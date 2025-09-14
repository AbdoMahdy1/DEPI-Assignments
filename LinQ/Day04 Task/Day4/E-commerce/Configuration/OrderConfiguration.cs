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
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> O)
        {
            O.ToTable("Orders");

            O.HasKey(O => O.Id);

            O.Property(O => O.Id)
                .UseIdentityColumn(1, 1);

            O.Property(O => O.OrderDate)
                .HasColumnType("date");

            O.HasMany(O => O.OrderProducts)
                .WithOne(OP => OP.Order)
                .HasForeignKey(OP => OP.OrderID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
