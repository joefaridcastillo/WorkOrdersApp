using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccessAPI.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Technician> Technicians { get; set; } = null!;
        public virtual DbSet<WorkOrder> WorkOrders { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Desktop\\WorkOrders.mdf;Integrated Security=True;Connect Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Technician>(entity =>
            {
                entity.Property(e => e.TechnicianId).HasColumnName("TechnicianID");

                entity.Property(e => e.TechnicianEmail).HasMaxLength(30);

                entity.Property(e => e.TechnicianName).HasMaxLength(30);
            });

            modelBuilder.Entity<WorkOrder>(entity =>
            {
                entity.HasKey(e => e.Wonum)
                    .HasName("PK_WorkOrder");

                entity.Property(e => e.Wonum).HasColumnName("WONum");

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.ContactNumber).HasMaxLength(25);

                entity.Property(e => e.DateAssigned).HasColumnType("datetime");

                entity.Property(e => e.DateComplete).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.TechnicianId).HasColumnName("TechnicianID");

                entity.HasOne(d => d.Technician)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.TechnicianId)
                    .HasConstraintName("FK_WorkOrder_Table_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
