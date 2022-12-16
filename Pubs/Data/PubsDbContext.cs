using Microsoft.EntityFrameworkCore;
using Pubs.Models;

namespace Pubs.Data
{
    public class PubsDbContext : DbContext
    {
        public PubsDbContext(DbContextOptions options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorTitle>().HasKey(x => new { x.AuthorId, x.TitleId});
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<AuthorTitle> AuthorTitles { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
