using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories


{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .HasData(
                new Product() { Id = 1, Name = "Ada", Price = 300 },
                     new Product() { Id = 2, Name = "Elif", Price = 400 },
                     new Product() { Id = 3, Name = "Gizem", Price = 500 },
                     new Product() { Id = 4, Name = "OSman", Price = 600 },
                     new Product() { Id = 5, Name = "Engin", Price = 700 },
                     new Product() { Id = 6, Name = "Begum", Price = 800 }


                );

            modelBuilder.Entity<Category>()
                 .HasData(
                new Category() { CategoryID=1, CategoryName = "Book"},
                    new Category() { CategoryID = 2, CategoryName = "Elektronik" }

                );

        }

    }
}
