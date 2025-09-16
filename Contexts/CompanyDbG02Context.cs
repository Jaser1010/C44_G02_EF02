using C44_G02_EF02.Configurations;
using C44_G02_EF02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EF02.Contexts
{
    public class CompanyDbG02Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseSqlServer("Server=.;Database=CompanyDbG02;Trusted_Connection=true;TrustServerCertificate=true;");
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
         =>   modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
