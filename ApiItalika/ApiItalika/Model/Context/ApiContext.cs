using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ApiItalika.Model.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiItalika.Model.Context
{
    public partial class ApiContext : DbContext
    {
        public ApiContext()
        {
        }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Tipo> Tipo { get; set; }
        public virtual DbSet<mySP> Series { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("producto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.IdTipo).HasColumnName("idTipo");

                entity.Property(e => e.Modelo)
                    .HasColumnName("modelo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerie)
                    .HasColumnName("numeroSerie")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(10)
                    .IsUnicode(false);
                
                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdTipo)
                    .HasConstraintName("FK_producto_Tipo");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<mySP>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.numeroSerie)
                    .IsRequired()
                    .HasColumnName("NumeroSerie")
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
