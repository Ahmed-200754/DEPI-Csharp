using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_EFDay03.Models;
using Microsoft.EntityFrameworkCore;

namespace LINQ_EFDay03.DbContexts
{
    internal class BookstoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database = BookstoreDB; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(B =>
            {
                B.Property(B=> B.Title)
                 .IsRequired()
                 .HasMaxLength(150);

                B.Property(B => B.Price)
                 .HasColumnType("decimal(8,2)");

                B.Property(B => B.PublishedDate)
                 .IsRequired(false);
            });
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
