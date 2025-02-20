using ApiProjectKampi.WebApi.Controllers.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProjectKampi.WebApi.Context
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Initial Catalog=ApiYummyDb; Integrated Security=True;");
        }

        // DbSet tanımlamaları
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Contact> Contacts { get; set; } // Burayı düzelt
        public DbSet<Feature> Features { get; set; }
        public DbSet<Image> Images { get; set; } // Burada da pluralize ettim
        public DbSet<Message> Messages { get; set; } // Aynı şekilde Messages
        public DbSet<Product> Products { get; set; } // Aynı şekilde Products
        public DbSet<Reservation> Reservations { get; set; } // Aynı şekilde Reservations
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonail> Testimonails { get; set; }
    }
}
