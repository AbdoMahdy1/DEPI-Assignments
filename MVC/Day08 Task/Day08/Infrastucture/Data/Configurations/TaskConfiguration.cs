using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configurations
{
    internal class TaskConfiguration : IEntityTypeConfiguration<TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> T)
        {
            T.ToTable("Tasks");

            T.HasKey(t => t.Id);

            T.Property(t => t.Id)
                .UseIdentityColumn(1, 1);

            T.Property(t => t.Title)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            T.Property(t => t.Description)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasMaxLength(500);

            T.Property(t => t.CreatedAt)
                .HasDefaultValueSql("getDate()");
        }
    }
}
