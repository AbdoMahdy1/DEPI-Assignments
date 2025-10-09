using Day02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day02.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
            S.ToTable("Students");
            S.HasKey(s => s.Id);

            S.Property(s => s.Name)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasColumnName("StuName")
                .HasMaxLength(50);

            S.Property(s => s.Age)
                .IsRequired(true);

            S.HasMany(s => s.Results)
                .WithOne(r => r.Student)
                .HasForeignKey(r => r.StuId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
