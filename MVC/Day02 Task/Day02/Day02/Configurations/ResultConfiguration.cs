using Day02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day02.Configurations
{
    public class ResultConfiguration : IEntityTypeConfiguration<StuCrsResult>
    {
        public void Configure(EntityTypeBuilder<StuCrsResult> R)
        {
            R.ToTable("StuCrsResults");
            R.HasKey(r => new { r.StuId, r.CourseId });

            R.Property(r => r.Grade)
                .IsRequired(true);
        }
    }
}
