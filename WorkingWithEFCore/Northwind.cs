using Microsoft.EntityFrameworkCore;
using PacktLibrary;

namespace WorkingWithEFCore
{
    public class Northwind : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "Data Source=.;Initial Catalog=Northwind;Integrated Security=true;MultipleActiveResultSets=true;";
            optionsBuilder.UseSqlServer(connection);
        }
        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            // example of using Fluent API instead of attributes
            // to limit the length of a category name to 15
            modelBuilder.Entity<Category>()
            .Property(category => category.CategoryName)
            .IsRequired() // NOT NULL
            .HasMaxLength(15);
        }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }
    }
}
