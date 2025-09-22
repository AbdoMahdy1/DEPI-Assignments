using Day02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day02.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> C)
        {
            C.ToTable("Courses");
            C.HasKey(c => c.Id);

            C.Property(c => c.Id)
                .UseIdentityColumn(1, 1);

            C.Property(c => c.Name)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasColumnName("CrsName")
                .HasMaxLength(50);

            C.Property(c => c.MinDegree)
                .IsRequired(true);
            
            C.Property(c => c.Degree)
                .IsRequired(true);

            C.HasMany(c => c.Teachers)
                .WithOne(t => t.Course)
                .HasForeignKey(t => t.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            C.HasMany(c => c.Results)
                .WithOne(r => r.Course)
                .HasForeignKey(r => r.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
