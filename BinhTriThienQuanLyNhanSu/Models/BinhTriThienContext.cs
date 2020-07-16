using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BinhTriThienQuanLyNhanSu.Models
{
    public partial class BinhTriThienContext : DbContext
    {
        public BinhTriThienContext()
        {
        }

        public BinhTriThienContext(DbContextOptions<BinhTriThienContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BacXepHang> BacXepHang { get; set; }
        public virtual DbSet<Cung> Cung { get; set; }
        public virtual DbSet<Ga> Ga { get; set; }
        public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoan { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<Phong> Phong { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-9DN6F6I;Initial Catalog=BinhTriThien;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BacXepHang>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UK_BacXepHang_MaBacXepHang")
                    .IsUnique();
            });

            modelBuilder.Entity<Cung>(entity =>
            {
                entity.HasIndex(e => e.AnToanVeSinhVien);

                entity.HasIndex(e => e.CongDoanVien);

                entity.HasIndex(e => e.CungPho);

                entity.HasIndex(e => e.CungTruong);

                entity.HasIndex(e => e.Ma)
                    .HasName("UK_Cung_MaCung")
                    .IsUnique();

                entity.HasOne(d => d.AnToanVeSinhVienNavigation)
                    .WithMany(p => p.CungAnToanVeSinhVienNavigation)
                    .HasForeignKey(d => d.AnToanVeSinhVien)
                    .HasConstraintName("FK_AnToanVeSinhVien_NhanVien");

                entity.HasOne(d => d.CongDoanVienNavigation)
                    .WithMany(p => p.CungCongDoanVienNavigation)
                    .HasForeignKey(d => d.CongDoanVien)
                    .HasConstraintName("FK_ConDoanVien_NhanVien");

                entity.HasOne(d => d.CungPhoNavigation)
                    .WithMany(p => p.CungCungPhoNavigation)
                    .HasForeignKey(d => d.CungPho)
                    .HasConstraintName("FK_CungPho_NhanVien");

                entity.HasOne(d => d.CungTruongNavigation)
                    .WithMany(p => p.CungCungTruongNavigation)
                    .HasForeignKey(d => d.CungTruong)
                    .HasConstraintName("FK_CungTruong_NhanVien");
            });

            modelBuilder.Entity<Ga>(entity =>
            {
                entity.HasIndex(e => e.CungId);

                entity.HasIndex(e => e.Ma)
                    .HasName("UK_Ga_MaGa")
                    .IsUnique();

                entity.HasOne(d => d.Cung)
                    .WithMany(p => p.Ga)
                    .HasForeignKey(d => d.CungId)
                    .HasConstraintName("FK_Ga_Cung");
            });

            modelBuilder.Entity<LoaiTaiKhoan>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UK_LoaiTaiKhoan_MaLoaiTaiKhoan");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasIndex(e => e.BacXepHangId);

                entity.HasIndex(e => e.LoaiTaiKhoanId);

                entity.HasIndex(e => e.Ma)
                    .HasName("UK_NhanVien_MaNhanVien")
                    .IsUnique();

                entity.HasOne(d => d.BacXepHang)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.BacXepHangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NhanVien_BacXepHang");

                entity.HasOne(d => d.Cung)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.CungId)
                    .HasConstraintName("FK_NhanVien_Cung");

                entity.HasOne(d => d.LoaiTaiKhoan)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.LoaiTaiKhoanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NhanVien_LoaiTaiKhoan");

                entity.HasOne(d => d.Phong)
                    .WithMany(p => p.NhanVien)
                    .HasForeignKey(d => d.PhongId)
                    .HasConstraintName("FK_NhanVien_Phong");
            });

            modelBuilder.Entity<Phong>(entity =>
            {
                entity.HasIndex(e => e.Ma)
                    .HasName("UK_Phong_MaPhong")
                    .IsUnique();

                entity.HasIndex(e => e.PhoPhong);

                entity.HasIndex(e => e.TruongPhong);

                entity.HasOne(d => d.PhoPhongNavigation)
                    .WithMany(p => p.PhongPhoPhongNavigation)
                    .HasForeignKey(d => d.PhoPhong)
                    .HasConstraintName("FK_Phong_NhanVien");

                entity.HasOne(d => d.TruongPhongNavigation)
                    .WithMany(p => p.PhongTruongPhongNavigation)
                    .HasForeignKey(d => d.TruongPhong)
                    .HasConstraintName("FK_TruongPhong_NhanVien");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
