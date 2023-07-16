namespace BooksNET6API.Models;

public class BookDBContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public BookDBContext(DbContextOptions<BookDBContext> options) : base(options)
    {

    }
}