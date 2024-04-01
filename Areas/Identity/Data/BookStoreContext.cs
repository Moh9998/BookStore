using BookStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data;

public class StoreContext : IdentityDbContext<IdentityUser>
{
    public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
    {
    }
        

    public DbSet<Book> Books { get; set; }

    public DbSet<Cart> Carts { get; set; }

    public DbSet<Orders> Orders { get; set; }

    public DbSet<Log> Logs { get; set; }
   

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);


        builder.Entity<Book>().HasData(
                    new Book
                    {
                        Id = 1,
                        Title = "The Great Gatsby",
                        Author = "F. Scott Fitzgerald",
                        Genre = "Fiction",
                        BooksInStock= 10,
                        Price = 7.99M,
                        Avalibality = true,
                        DateAded = DateTime.Now
                    },
                    new Book
                    {
                        Id = 2,
                        Title = "Lord of the Flies",
                        Author = "William Golding",
                        Genre = "Fiction",
                        BooksInStock=10,
                        Price = 7.99M,
                        Avalibality = true,
                        DateAded = DateTime.Now
                    },
                    new Book
                    {
                        Id = 3,
                        Title = "Asp.NetCore WebApi" +
"Build Rubust backends",
                        Author = "Joydip Kanjilal",
                        Genre = "Programming",
                        BooksInStock=10,
                        Price = 7.99M,
                        Avalibality = true,
                        DateAded = DateTime.Now
                    });
    }
}
