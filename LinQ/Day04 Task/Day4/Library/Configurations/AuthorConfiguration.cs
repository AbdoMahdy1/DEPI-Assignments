using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Configurations
{
    internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> A)
        {
            A.ToTable("Author");

            A.HasKey(A => A.Id);

            A.Property(a => a.Id)
                .UseIdentityColumn(1, 1);

            A.Property(a => a.Name)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasColumnName("AuthorName")
                .HasMaxLength(50);

            A.Property(a => a.BirthDate)
                .HasColumnType("date")
                .HasColumnName("AuthorBD");

            A.HasMany(A => A.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
