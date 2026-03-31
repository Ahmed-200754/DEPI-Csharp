using LINQ_EFDay04.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LINQ_EFDay04.DbContexts
{
    internal class ECommerceDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=ECommerceDB; Trusted_Connection=True; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(C =>
            {
                C.Property(c => c.Name)
                 .IsRequired()
                 .HasMaxLength(100);
            });

            modelBuilder.Entity<Product>(P =>
            {
                P.Property(p => p.Name)
                 .IsRequired()
                 .HasMaxLength(150);

                P.Property(p => p.Price)
                 .HasColumnType("decimal(10,2)");

                P.HasOne(p => p.Category)
                 .WithMany(c => c.Products)
                 .HasForeignKey(p => p.CategoryId)
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Customer>(C =>
            {
                C.Property(c => c.Name)
                 .IsRequired()
                 .HasMaxLength(100);

                C.Property(c => c.Email)
                 .IsRequired()
                 .HasMaxLength(200);
            });

            modelBuilder.Entity<Order>(O =>
            {
                O.Property(o => o.OrderDate)
                 .IsRequired();

                O.HasOne(o => o.Customer)
                 .WithMany(c => c.Orders)
                 .HasForeignKey(o => o.CustomerId)
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<OrderDetail>(OD =>
            {
                OD.HasKey(od => new { od.OrderId, od.ProductId });

                OD.Property(od => od.Quantity)
                  .IsRequired();

                OD.HasOne(od => od.Order)
                  .WithMany(o => o.OrderDetails)
                  .HasForeignKey(od => od.OrderId)
                  .OnDelete(DeleteBehavior.Cascade);

                OD.HasOne(od => od.Product)
                  .WithMany(p => p.OrderDetails)
                  .HasForeignKey(od => od.ProductId)
                  .OnDelete(DeleteBehavior.Cascade);
            });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
