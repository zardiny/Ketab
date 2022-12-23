using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ketab.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BooksInfo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Writer = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksInfo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BooksInfo",
                columns: new[] { "Id", "Category", "Name", "Writer", "Year" },
                values: new object[,]
                {
                    { 1L, "Classic", "The Great Gatsby", "Classic F.Scott Fitzgerald", 1925 },
                    { 2L, "Classic", "Pride and Prejudice", "Jane Austen", 1813 },
                    { 3L, "Historical fiction", "Wolf Hall", "Hilary Mantel", 2009 },
                    { 4L, "Historical fiction", "All the Light We Cannot See", "Anthony Doerr", 2014 },
                    { 5L, "Humour and satire", "The Sellout", "Paul Beatty", 2015 },
                    { 6L, "Humour and satire", "Cat's Cradle", "Kurt Vonnegut", 1963 },
                    { 7L, " Adventure stories", "Treasure Island", "Robert Louis Stevenson", 1882 },
                    { 8L, "Adventure stories", "The Call of the Wild", "Jack London", 1903 },
                    { 9L, "Crime", "The Silent Patient", "Alex Michaelides", 2019 },
                    { 10L, "Crime", "The Girl with the Dragon Tattoo", "Stieg Larsson", 2005 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksInfo");
        }
    }
}
