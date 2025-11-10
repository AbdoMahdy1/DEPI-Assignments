using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.DbContent
{
    public class CoursesDbContext: DbContext
    {
        public CoursesDbContext(): base() { }

        public CoursesDbContext(DbContextOptions options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CoursesDbContext).Assembly);
        }

        public DbSet<Course> Courses { get; set; }
    }
}
