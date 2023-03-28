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

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    //Assembly tüm mapping sınıflarını tek tek çağırmak yerine, IEntityTypeConfiguration
        //    //sınıfından kalıtım alan tüm mapping sınıflarını çağırır
        //    builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //}
    }
}
