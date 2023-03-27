using FoodBox.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FoodBox.Data.Context
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreProduct> StoreProducts { get; set; }
        public DbSet<StoreUser> StoreUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Assembly 
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
