using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EFDay01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay01.Configuration_Classes
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> P)
        {
            P.ToTable("Projects");

            P.HasKey(P => P.Id);
            
            P.Property(P => P.Id)
                .UseIdentityColumn(10, 10);

            P.Property(P => P.Name)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasColumnName("ProjectName")
                .HasDefaultValue("OurProject")
                .HasMaxLength(50);

            P.Property(P => P.Cost)
                .IsRequired(true)
                .HasColumnType("money")
                .HasColumnName("ProjectCost");

            P.HasCheckConstraint("CK_Project_Cost", "[ProjectCost] >= 500000 AND [ProjectCost] <= 3500000");
        }
    }
}
