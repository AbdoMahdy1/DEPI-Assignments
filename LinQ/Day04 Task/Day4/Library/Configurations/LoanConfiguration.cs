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
    internal class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> L)
        {
            L.ToTable("Loan");

            L.HasKey(L => new { L.BorrowerId, L.BookId });

            L.Property(l => l.LoanDate)
                .IsRequired(true);
            
            L.Property(l => l.ReturnDate)
                .IsRequired(true);
        }
    }
}
