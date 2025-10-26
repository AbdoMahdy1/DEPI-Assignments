using Microsoft.EntityFrameworkCore;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AssessmentDbContext : DbContext
    {
        public AssessmentDbContext() : base()
        {

        }

        public AssessmentDbContext(DbContextOptions options): base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Assessment;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        //}

        public DbSet<TaskItem> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssessmentDbContext).Assembly);
        }
    }
}
