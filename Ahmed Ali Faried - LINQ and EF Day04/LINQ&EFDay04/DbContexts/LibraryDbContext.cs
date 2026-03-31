using LINQ_EFDay04.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_EFDay04.DbContexts
{
    internal class LibraryDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=LibraryDB; Trusted_Connection=True; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(A =>
            {
                A.Property(a => a.Name)
                 .IsRequired()
                 .HasMaxLength(100);

                A.Property(a => a.BirthDate)
                 .IsRequired();
            });

            modelBuilder.Entity<Book>(B =>
            {
                B.Property(b => b.Title)
                 .IsRequired()
                 .HasMaxLength(150);

                B.Property(b => b.ISBN)
                 .IsRequired()
                 .HasMaxLength(50);

                B.HasOne(b => b.Author)
                 .WithMany(a => a.Books)
                 .HasForeignKey(b => b.AuthorId)
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Borrower>(B =>
            {
                B.Property(b => b.Name)
                 .IsRequired()
                 .HasMaxLength(100);

                B.Property(b => b.MembershipDate)
                 .IsRequired();
            });

            modelBuilder.Entity<Loan>(L =>
            {
                L.HasKey(l => new { l.BookId, l.BorrowerId });

                L.Property(l => l.LoanDate)
                 .IsRequired();

                L.Property(l => l.ReturnDate)
                 .IsRequired(false);

                L.HasOne(l => l.Book)
                 .WithMany(b => b.Loans)
                 .HasForeignKey(l => l.BookId)
                 .OnDelete(DeleteBehavior.Cascade);

                L.HasOne(l => l.Borrower)
                 .WithMany(b => b.Loans)
                 .HasForeignKey(l => l.BorrowerId)
                 .OnDelete(DeleteBehavior.Cascade);
            });
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Loan> Loans { get; set; }
    }
}
