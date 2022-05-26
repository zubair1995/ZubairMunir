using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemsLtd.Training.ECommerce.Model;

namespace SystemsLtd.Training.ECommerce.Repository
{
    public class ECommerceDBContext : DbContext
    {
        public ECommerceDBContext()
        {
        }
        public ECommerceDBContext(DbContextOptions<ECommerceDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost;Database=ECommerceDB;Trusted_Connection=True;Integrated Security=false;User ID=sa;Password=Password.1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Customer>().ToTable("Customer");
        }
    }
}
