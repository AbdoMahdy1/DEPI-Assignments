using System;
using E_commerce.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_commerce.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> Co)
        {
            Co.ToTable("Category");

            Co.HasKey(c => c.Id);

            Co.Property(c => c.Id)
                .UseIdentityColumn(1, 1);

            Co.Property(c => c.Name)
                .HasColumnType("varchar")
                .HasColumnName("CategoryName")
                .HasMaxLength(50);

            Co.HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
