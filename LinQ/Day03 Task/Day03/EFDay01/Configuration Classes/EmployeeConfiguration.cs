using Microsoft.EntityFrameworkCore;
using System;
using EFDay01.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFDay01.Configuration_Classes
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
            E.ToTable("Employees");

            E.HasKey(E => E.Id);

            E.Property(E => E.Id)
                .UseIdentityColumn(1,1);

            E.Property(E => E.Name)
                .IsRequired(false)
                .HasColumnType("varchar")
                .HasColumnName("EmpName")
                .HasMaxLength(50);

            E.Property(E => E.Salary)
                .IsRequired(true)
                .HasColumnType("money")
                .HasColumnName("Salary")
                .HasPrecision(18, 2);

            E.Property(E => E.Age)
                .IsRequired(false);
        }
    }
}
