using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthCare.Configurations
{
    internal class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> P)
        {
            P.ToTable("Patients");

            P.HasKey(P => P.Id);

            P.Property(P => P.Id)
                .UseIdentityColumn(1, 1);

            P.Property(P => P.Name)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasColumnName("PatientName")
                .HasMaxLength(50);

            P.Property(P => P.DateOfBirth)
                .IsRequired(true)
                .HasColumnType("date");

            P.HasMany(P => P.PatientDocs)
                .WithOne(Pd => Pd.Patient)
                .HasForeignKey(Pd => Pd.PatientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
