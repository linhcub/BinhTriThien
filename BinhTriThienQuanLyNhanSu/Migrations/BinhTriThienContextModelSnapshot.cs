﻿// <auto-generated />
using System;
using BinhTriThienQuanLyNhanSu.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BinhTriThienQuanLyNhanSu.Migrations
{
    [DbContext(typeof(BinhTriThienContext))]
    partial class BinhTriThienContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BinhTriThienQuanLyNhanSu.Models.BacXepHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("HeSoLuong")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasName("UK_BacXepHang_MaBacXepHang");

                    b.ToTable("BacXepHang");
                });

            modelBuilder.Entity("BinhTriThienQuanLyNhanSu.Models.Cung", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnToanVeSinhVien")
                        .HasColumnType("int");

                    b.Property<int?>("CongDoanVien")
                        .HasColumnType("int");

                    b.Property<int?>("CungPho")
                        .HasColumnType("int");

                    b.Property<int?>("CungTruong")
                        .HasColumnType("int");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("AnToanVeSinhVien");

                    b.HasIndex("CongDoanVien");

                    b.HasIndex("CungPho");

                    b.HasIndex("CungTruong");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasName("UK_Cung_MaCung");

                    b.ToTable("Cung");
                });

            modelBuilder.Entity("BinhTriThienQuanLyNhanSu.Models.Ga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CungId")
                        .HasColumnType("int");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CungId");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasName("UK_Ga_MaGa");

                    b.ToTable("Ga");
                });

            modelBuilder.Entity("BinhTriThienQuanLyNhanSu.Models.LoaiTaiKhoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CapDo")
                        .HasColumnType("int");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Ma")
                        .HasName("UK_LoaiTaiKhoan_MaLoaiTaiKhoan");

                    b.ToTable("LoaiTaiKhoan");
                });

            modelBuilder.Entity("BinhTriThienQuanLyNhanSu.Models.NhanVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnhDaiDien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BacXepHangId")
                        .HasColumnType("int");

                    b.Property<int?>("CungId")
                        .HasColumnType("int");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("DienThoaiCoDinh")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("DienThoaiDiDong")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Ho")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("LoaiTaiKhoanId")
                        .HasColumnType("int");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("PhongId")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("BacXepHangId");

                    b.HasIndex("CungId");

                    b.HasIndex("LoaiTaiKhoanId");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasName("UK_NhanVien_MaNhanVien");

                    b.HasIndex("PhongId");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("BinhTriThienQuanLyNhanSu.Models.Phong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int?>("PhoPhong")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("TruongPhong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasName("UK_Phong_MaPhong");

                    b.HasIndex("PhoPhong");

                    b.HasIndex("TruongPhong");

                    b.ToTable("Phong");
                });

            modelBuilder.Entity("BinhTriThienQuanLyNhanSu.Models.Cung", b =>
                {
                    b.HasOne("BinhTriThienQuanLyNhanSu.Models.NhanVien", "AnToanVeSinhVienNavigation")
                        .WithMany("CungAnToanVeSinhVienNavigation")
                        .HasForeignKey("AnToanVeSinhVien")
                        .HasConstraintName("FK_AnToanVeSinhVien_NhanVien");

                    b.HasOne("BinhTriThienQuanLyNhanSu.Models.NhanVien", "CongDoanVienNavigation")
                        .WithMany("CungCongDoanVienNavigation")
                        .HasForeignKey("CongDoanVien")
                        .HasConstraintName("FK_ConDoanVien_NhanVien");

                    b.HasOne("BinhTriThienQuanLyNhanSu.Models.NhanVien", "CungPhoNavigation")
                        .WithMany("CungCungPhoNavigation")
                        .HasForeignKey("CungPho")
                        .HasConstraintName("FK_CungPho_NhanVien");

                    b.HasOne("BinhTriThienQuanLyNhanSu.Models.NhanVien", "CungTruongNavigation")
                        .WithMany("CungCungTruongNavigation")
                        .HasForeignKey("CungTruong")
                        .HasConstraintName("FK_CungTruong_NhanVien");
                });

            modelBuilder.Entity("BinhTriThienQuanLyNhanSu.Models.Ga", b =>
                {
                    b.HasOne("BinhTriThienQuanLyNhanSu.Models.Cung", "Cung")
                        .WithMany("Ga")
                        .HasForeignKey("CungId")
                        .HasConstraintName("FK_Ga_Cung");
                });

            modelBuilder.Entity("BinhTriThienQuanLyNhanSu.Models.NhanVien", b =>
                {
                    b.HasOne("BinhTriThienQuanLyNhanSu.Models.BacXepHang", "BacXepHang")
                        .WithMany("NhanVien")
                        .HasForeignKey("BacXepHangId")
                        .HasConstraintName("FK_NhanVien_BacXepHang")
                        .IsRequired();

                    b.HasOne("BinhTriThienQuanLyNhanSu.Models.Cung", "Cung")
                        .WithMany("NhanVien")
                        .HasForeignKey("CungId")
                        .HasConstraintName("FK_NhanVien_Cung");

                    b.HasOne("BinhTriThienQuanLyNhanSu.Models.LoaiTaiKhoan", "LoaiTaiKhoan")
                        .WithMany("NhanVien")
                        .HasForeignKey("LoaiTaiKhoanId")
                        .HasConstraintName("FK_NhanVien_LoaiTaiKhoan")
                        .IsRequired();

                    b.HasOne("BinhTriThienQuanLyNhanSu.Models.Phong", "Phong")
                        .WithMany("NhanVien")
                        .HasForeignKey("PhongId")
                        .HasConstraintName("FK_NhanVien_Phong");
                });

            modelBuilder.Entity("BinhTriThienQuanLyNhanSu.Models.Phong", b =>
                {
                    b.HasOne("BinhTriThienQuanLyNhanSu.Models.NhanVien", "PhoPhongNavigation")
                        .WithMany("PhongPhoPhongNavigation")
                        .HasForeignKey("PhoPhong")
                        .HasConstraintName("FK_Phong_NhanVien");

                    b.HasOne("BinhTriThienQuanLyNhanSu.Models.NhanVien", "TruongPhongNavigation")
                        .WithMany("PhongTruongPhongNavigation")
                        .HasForeignKey("TruongPhong")
                        .HasConstraintName("FK_TruongPhong_NhanVien");
                });
#pragma warning restore 612, 618
        }
    }
}
