using Microsoft.EntityFrameworkCore;

namespace KetabInfo
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
                new Book()
                {
                    Id = 1,
                    Name = "The Great Gatsby",
                    Category = "Classic",
                    Writer = "Classic F.Scott Fitzgerald",
                    Year = 1925
                },
                new Book()
                {
                    Id = 2,
                    Name = "Pride and Prejudice",
                    Category = "Classic",
                    Writer = "Jane Austen",
                    Year = 1813
                },
                new Book()
                {
                    Id = 3,
                    Name = "Wolf Hall",
                    Category = "Historical fiction",
                    Writer = "Hilary Mantel",
                    Year = 2009
                },
                new Book()
                {
                    Id = 4,
                    Name = "All the Light We Cannot See",
                    Category = "Historical fiction",
                    Writer = "Anthony Doerr",
                    Year = 2014
                },
                new Book() 
                { 
                    Id = 5,
                    Name = "The Sellout",
                    Category = "Humour and satire",
                    Writer = "Paul Beatty",
                    Year = 2015
                },
                new Book()
                {
                    Id = 6,
                    Name = "Cat's Cradle",
                    Category = "Humour and satire",
                    Writer = "Kurt Vonnegut",
                    Year = 1963
                },
                new Book()
                {
                    Id = 7,
                    Name = "Treasure Island",
                    Category = "Adventure stories",
                    Writer = "Robert Louis Stevenson",
                    Year = 1882
                },
                new Book()
                {
                    Id = 8,
                    Name = "The Call of the Wild",
                    Category = "Adventure stories",
                    Writer = "Jack London",
                    Year = 1903
                },
                new Book()
                {
                    Id = 9,
                    Name = "The Silent Patient",
                    Category = "Crime",
                    Writer = "Alex Michaelides",
                    Year = 2019
                },
                new Book()
                {
                    Id = 10,
                    Name = "The Girl with the Dragon Tattoo",
                    Category = "Crime",
                    Writer = "Stieg Larsson",
                    Year = 2005
                }
                );
        }
    }
}
