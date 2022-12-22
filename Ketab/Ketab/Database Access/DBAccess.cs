using Microsoft.EntityFrameworkCore;

namespace Ketab
{
    public class DBAccess : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Library.db;");
        }

        public DbSet<Book> BooksInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book() { Id = 1, Category = "Classic", Name = "The Great Gatsby", Writer = "F. Scott Fitzgerald", Year = 1925 },
                new Book() { Id = 2, Category = "Classic", Name = "Pride and Prejudice", Writer = "Jane Austen", Year = 1813 }
            );
        }
    }
}
