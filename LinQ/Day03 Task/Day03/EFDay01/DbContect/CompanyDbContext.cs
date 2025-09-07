using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDay01.Configuration_Classes;
using EFDay01.Models;
using Microsoft.EntityFrameworkCore;



namespace EFDay01.DbContect
{
    internal class CompanyDbContext : DbContext
    {
        // Connection Data
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Company;Trusted_Connection=True;");
        }

        //Map Model(class)
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Test> Tests { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //level 03
            //modelBuilder.ApplyConfiguration(new DepartmentConfigurations());

            // self : one line for all configurations >> Project

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyDbContext).Assembly);
        }
    }
}
