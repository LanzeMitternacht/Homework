using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BooksPublish;

public class BooksPublishDbContext : DbContext
{
    public BooksPublishDbContext() : base("name=BooksPublish.Properties.Settings.BooksPublishConnectionString")
    {}

    public DbSet<Author> Authors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


        modelBuilder.Entity<Book>()
            .HasRequired(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.IdAuthor);

        modelBuilder.Entity<Book>()
            .HasRequired(b => b.Publisher)
            .WithMany(p => p.Books)
            .HasForeignKey(b => b.IdPublisher);
    }
}

