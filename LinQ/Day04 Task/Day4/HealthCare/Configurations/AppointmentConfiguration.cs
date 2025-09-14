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
    internal class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> A)
        {
            A.ToTable("Appointments");

            A.HasKey(A => new { A.DoctorId, A.PatientId });

            A.Property(A => A.AppointmentDate)
                .IsRequired(true)
                .HasColumnType("date");
        }
    }
}
