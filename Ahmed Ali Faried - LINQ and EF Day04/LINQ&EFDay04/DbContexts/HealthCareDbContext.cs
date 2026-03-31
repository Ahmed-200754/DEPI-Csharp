using LINQ_EFDay04.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_EFDay04.DbContexts
{
    internal class HealthCareDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=HealthCareDB; Trusted_Connection=True; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(P =>
            {
                P.Property(p => p.Name)
                 .IsRequired()
                 .HasMaxLength(100);

                P.Property(p => p.DateOfBirth)
                 .IsRequired();
            });

            modelBuilder.Entity<Doctor>(D =>
            {
                D.Property(d => d.Name)
                 .IsRequired()
                 .HasMaxLength(100);

                D.Property(d => d.Specialization)
                 .IsRequired()
                 .HasMaxLength(100);
            });

            modelBuilder.Entity<Appointment>(A =>
            {
                A.HasKey(a => new { a.PatientId, a.DoctorId, a.AppointmentDate });

                A.Property(a => a.AppointmentDate)
                 .IsRequired();

                A.HasOne(a => a.patient)
                 .WithMany(p => p.Appointments)
                 .HasForeignKey(a => a.PatientId)
                 .OnDelete(DeleteBehavior.Cascade);

                A.HasOne(a => a.doctor)
                 .WithMany(d => d.Appointments)
                 .HasForeignKey(a => a.DoctorId)
                 .OnDelete(DeleteBehavior.Cascade);
            });
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
