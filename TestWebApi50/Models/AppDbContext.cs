using System;
using Microsoft.EntityFrameworkCore;

namespace TestWebApi50.Models {
    public class AppDbContext : DbContext {

        public DbSet<Customer> Customers { get; set; }

        public AppDbContext(DbContextOptions options) : base(options) {
        }
    }
}
