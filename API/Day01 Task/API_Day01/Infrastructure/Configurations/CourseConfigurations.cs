using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> C)
        {
            C.ToTable("Courses");

            C.HasKey(c => c.Id);

            C.Property(c => c.Id)
                .UseIdentityColumn(1, 1);

            C.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            C.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(150);

            C.Property(c => c.Duration)
                .IsRequired();
        }
    }
}
