using Microsoft.EntityFrameworkCore;
using System.Core.Entities;

namespace System.Repository.Contexts
{
    public class OrderSystemDbContext : DbContext
    {
        public OrderSystemDbContext(DbContextOptions<OrderSystemDbContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseInMemoryDatabase("InMemoryDb");
        //    base.OnConfiguring(optionsBuilder);
        //}


        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Invoice> Invoices { get; set; }
    }
}
