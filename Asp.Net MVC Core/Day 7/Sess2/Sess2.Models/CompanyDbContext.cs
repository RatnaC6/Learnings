using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query;

namespace Sess2.Models
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext()
        {

        }

        public CompanyDbContext(DbContextOptions<CompanyDbContext> options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(
                connectionString: "host=localhost;database=Company;user id = postgres; password = root;");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers  { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
