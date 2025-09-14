using System;
using Library.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Configurations
{
    internal class BookConfigurations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> B)
        {
            B.ToTable("Books");

            B.HasKey(B => B.Id);

            B.Property(B => B.Id)
                .UseIdentityColumn(1, 1);

            B.Property(B => B.Title)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasColumnName("Title")
                .HasMaxLength(50);

            B.Property(B => B.ISBN)
                .IsRequired(true)
                .IsUnicode(true);

            B.HasMany(B => B.BookBorrowers)
                .WithOne(BB => BB.Book)
                .HasForeignKey(BB => BB.BookId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
