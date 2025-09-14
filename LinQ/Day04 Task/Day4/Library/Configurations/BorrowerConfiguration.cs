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
    internal class BorrowerConfiguration : IEntityTypeConfiguration<Borrower>
    {
        public void Configure(EntityTypeBuilder<Borrower> Br)
        {
            Br.ToTable("Borrowers");

            Br.HasKey(Br => Br.Id);

            Br.Property(Br => Br.Id)
                .UseIdentityColumn(1, 1);

            Br.Property(Br => Br.Name)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasColumnName("BorrowerName")
                .HasMaxLength(50);

            Br.Property(Br => Br.MembershipDate)
                .HasColumnType("date");

            Br.HasMany(Br => Br.BorrowerBooks)
                .WithOne(Bb => Bb.Borrower)
                .HasForeignKey(Bb => Bb.BorrowerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
