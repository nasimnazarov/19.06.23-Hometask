using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Infrastructure.Context;

public class DataContext: DbContext
{
    private readonly DbContextOptions<DataContext> _options;

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        _options = options;
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookAuthor> Bookauthors { get; set; }
    public DbSet<BookEditor> Bookeditors { get; set; }
    public DbSet<Editor> Editors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookAuthor>().HasKey(k => new { k.AuthorId, k.Isbn });
        modelBuilder.Entity<BookEditor>().HasKey(k => new { k.Isbn, k.EditorId });
        base.OnModelCreating(modelBuilder);
    }
}