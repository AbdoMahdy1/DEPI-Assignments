using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using EFDay01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFDay01.Configuration_Classes
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.ToTable("Departments");
            
            D.HasKey(D => D.Id);
            
            D.Property(D => D.Id)
                    .UseIdentityColumn(10, 10);
            
            D.Property(D => D.Name)
                    .IsRequired(true)
                    .HasColumnType("varchar")
                    .HasColumnName("DeptName")
                    .HasDefaultValue("Dept")
                    .HasMaxLength(50);
        }
    }
}
