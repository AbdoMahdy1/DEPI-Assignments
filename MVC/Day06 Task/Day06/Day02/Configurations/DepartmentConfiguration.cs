using Day02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Day02.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.ToTable("Departments");

            D.HasKey(D => D.Id);

            D.Property(d => d.Id)
                .UseIdentityColumn(1, 1);

            D.Property(d => d.Name)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasColumnName("DeptName")
                .HasMaxLength(50);

            D.Property(d => d.MgrName)
                .IsRequired(false)
                .HasColumnType("varchar")
                .HasColumnName("Manager")
                .HasMaxLength(50);

            D.HasMany(d => d.Teachers)
                .WithOne(t => t.Department)
                .HasForeignKey(t => t.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            D.HasMany(d=> d.Courses)
                .WithOne(c => c.Department)
                .HasForeignKey(c => c.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            D.HasMany(d=> d.Students)
                .WithOne(s => s.Department)
                .HasForeignKey(s => s.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
