using System;
using System.Collections.Generic;
using DAL.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public partial class ThiThuDBContext : DbContext
{
    public ThiThuDBContext()
    {
    }

    public ThiThuDBContext(DbContextOptions<ThiThuDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chunhan> Chunhans { get; set; }

    public virtual DbSet<Cuahang> Cuahangs { get; set; }

    public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }

    public virtual DbSet<Phuhuynh> Phuhuynhs { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    public virtual DbSet<Sinhvien> Sinhviens { get; set; }

    public virtual DbSet<Thucung> Thucungs { get; set; }

    public virtual DbSet<Trungtam> Trungtams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=SURINRIN\\SQLEXPRESS01;Initial Catalog= SOF205_FINAL_TEST;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chunhan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CHUNHAN__3213E83FA755E434");
        });

        modelBuilder.Entity<Cuahang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUAHANG__3213E83FFEACA05B");

            entity.HasOne(d => d.IdCnNavigation).WithMany(p => p.Cuahangs).HasConstraintName("FKCH_TT");
        });

        modelBuilder.Entity<Nhacungcap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NHACUNGC__3213E83FADCF0D89");
        });

        modelBuilder.Entity<Phuhuynh>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PHUHUYNH__3213E83F9071D519");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SANPHAM__3213E83F3DEDE47A");

            entity.HasOne(d => d.IdNccNavigation).WithMany(p => p.Sanphams).HasConstraintName("FK_SP_NCC");
        });

        modelBuilder.Entity<Sinhvien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SINHVIEN__3213E83FCFA39CB0");

            entity.HasOne(d => d.IdPhNavigation).WithMany(p => p.Sinhviens).HasConstraintName("FK_SV_PH");
        });

        modelBuilder.Entity<Thucung>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__THUCUNG__3213E83F70471D6B");

            entity.HasOne(d => d.IdCnNavigation).WithMany(p => p.Thucungs).HasConstraintName("FK_TC_CN");
        });

        modelBuilder.Entity<Trungtam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TRUNGTAM__3213E83FCB4F2B37");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
