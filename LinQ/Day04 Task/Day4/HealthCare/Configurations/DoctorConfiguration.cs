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
    internal class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> D)
        {
            D.ToTable("Doctors");

            D.HasKey(D => D.Id);

            D.Property(d => d.Id)
                .UseIdentityColumn(1, 1);

            D.Property(d => d.Name)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasColumnName("DoctorName")
                .HasMaxLength(50);

            D.Property(d => d.Specialization)
                .IsRequired(true)
                .HasColumnType("varchar");

            D.HasMany(D => D.DoctorPatients)
                .WithOne(Dp => Dp.Doctor)
                .HasForeignKey(Dp => Dp.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
