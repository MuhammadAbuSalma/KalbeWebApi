using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace KalbeWebApi.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MCurrency> MCurrencys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Server=DESKTOP-LECTQ14\\SQLSERVER2017; Database=KALBE; User ID=sa;Password=P@ssw0rd;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MCurrency>().HasKey(x => new { x.CurrencyId });
            //modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            //modelBuilder.Entity<MCurrency>(entity =>
            //{
            //    entity.HasKey(e => e.CurrencyId);

            //    entity.ToTable("MCurrency");

            //    entity.Property(e => e.CurrencyId)
            //        .HasMaxLength(3)
            //        .IsUnicode(false)
            //        .HasColumnName("CurrencyID");

            //    entity.Property(e => e.CurrencyDesc)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);
            //});

            //OnModelCreatingPartial(modelBuilder);
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
