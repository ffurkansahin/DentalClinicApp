using System;
using System.Collections.Generic;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityLayer;

public partial class DentalDbContext : DbContext
{
    public DentalDbContext()
    {
    }

    public DentalDbContext(DbContextOptions<DentalDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Prescription> Prescriptions { get; set; }

    public virtual DbSet<Treatment> Treatments { get; set; }

    public virtual DbSet<Users> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Server=localhost;Database=DentalDb;Trusted_Connection=True;;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Patient).HasMaxLength(50);
            entity.Property(e => e.Time).HasColumnType("date");
            entity.Property(e => e.Treatment).HasMaxLength(50);
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address).HasMaxLength(400);
            entity.Property(e => e.Allergies).HasMaxLength(400);
            entity.Property(e => e.BirthDate).HasColumnType("date");
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<Prescription>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Medicines).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Patient).HasMaxLength(50);
            entity.Property(e => e.Treatment).HasMaxLength(50);
        });

        modelBuilder.Entity<Treatment>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Users>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
