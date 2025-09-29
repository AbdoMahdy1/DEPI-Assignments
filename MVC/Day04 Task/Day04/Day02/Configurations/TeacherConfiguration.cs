using Day02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Day02.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> T)
        {
            T.ToTable("Teachers");
            T.HasKey(t =>  t.Id);

            T.Property(t => t.Id)
                .UseIdentityColumn(1, 1);

            T.Property(t => t.Name)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasColumnName("TeacherName")
                .HasMaxLength(50);

            T.Property(t => t.Salary)
                .IsRequired(true)
                .HasColumnType("money");

            T.Property(t => t.Address)
                .IsRequired(false)
                .HasColumnType("varchar");
        }
    }
}
