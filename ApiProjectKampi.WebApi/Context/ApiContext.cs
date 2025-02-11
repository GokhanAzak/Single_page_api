using ApiProjectKampi.WebApi.Controllers.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProjectKampi.WebApi.Context
{
    public class ApiContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=;initial catalog =ApiYummyDb; integrated  security= true;");


        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Service> Service { get; set; } 
        public DbSet<Testimonail> Testimonails { get; set; } 





         

    }
}
