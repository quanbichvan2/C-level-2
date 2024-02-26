using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASM_PS28709_QuanBichVan_SD18322.Models
{
    public partial class Asingment_C2Context : DbContext
    {
        public Asingment_C2Context()
        {
        }

        public Asingment_C2Context(DbContextOptions<Asingment_C2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=Yun\\SQLExpress;Database=Asingment_C#2;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.IdClass)
                    .HasName("PK__Class__17317A5A6FE5BB7B");

                entity.ToTable("Class");

                entity.Property(e => e.IdClass).HasColumnName("idClass");

                entity.Property(e => e.NameClass).HasMaxLength(50);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StId)
                    .HasName("PK__Student__C33CEFE24752C947");

                entity.ToTable("Student");

                entity.Property(e => e.StId).HasColumnName("StID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdClass).HasColumnName("idClass");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdClassNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.IdClass)
                    .HasConstraintName("FK__Student__idClass__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
