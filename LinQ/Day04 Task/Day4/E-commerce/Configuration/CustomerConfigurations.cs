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
    internal class CustomerConfigurations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> C)
        {
            C.ToTable("Customers");

            C.HasKey(C => C.Id);

            C.Property(C => C.Id)
                .UseIdentityColumn(1, 1);

            C.Property(c => c.Name)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasColumnName("CustomerName")
                .HasMaxLength(50);

            C.Property(C => C.Email)
                .HasColumnType("varchar")
                .HasColumnName("Email").
                HasMaxLength(50);

            C.HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);
        }
    }
}
