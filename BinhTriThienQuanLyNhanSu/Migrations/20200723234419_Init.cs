using Microsoft.EntityFrameworkCore.Migrations;

namespace BinhTriThienQuanLyNhanSu.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BacXepHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(maxLength: 10, nullable: false),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    HeSoLuong = table.Column<decimal>(type: "decimal(5, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BacXepHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTaiKhoan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(maxLength: 10, nullable: false),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    CapDo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTaiKhoan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(maxLength: 10, nullable: false),
                    MatKhau = table.Column<string>(maxLength: 50, nullable: false),
                    Ho = table.Column<string>(maxLength: 50, nullable: false),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    DienThoaiDiDong = table.Column<string>(maxLength: 50, nullable: true),
                    DienThoaiCoDinh = table.Column<string>(maxLength: 50, nullable: true),
                    LoaiTaiKhoanId = table.Column<int>(nullable: false),
                    BacXepHangId = table.Column<int>(nullable: true),
                    AnhDaiDien = table.Column<string>(nullable: true),
                    CungId = table.Column<int>(nullable: true),
                    PhongId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_BacXepHang",
                        column: x => x.BacXepHangId,
                        principalTable: "BacXepHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVien_LoaiTaiKhoan",
                        column: x => x.LoaiTaiKhoanId,
                        principalTable: "LoaiTaiKhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cung",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(maxLength: 10, nullable: false),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    CungTruong = table.Column<int>(nullable: true),
                    CungPho = table.Column<int>(nullable: true),
                    AnToanVeSinhVien = table.Column<int>(nullable: true),
                    CongDoanVien = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cung", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnToanVeSinhVien_NhanVien",
                        column: x => x.AnToanVeSinhVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConDoanVien_NhanVien",
                        column: x => x.CongDoanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CungPho_NhanVien",
                        column: x => x.CungPho,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CungTruong_NhanVien",
                        column: x => x.CungTruong,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phong",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(maxLength: 10, nullable: false),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    TruongPhong = table.Column<int>(nullable: true),
                    PhoPhong = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phong_NhanVien",
                        column: x => x.PhoPhong,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TruongPhong_NhanVien",
                        column: x => x.TruongPhong,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(maxLength: 10, nullable: false),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(maxLength: 100, nullable: true),
                    CungId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ga_Cung",
                        column: x => x.CungId,
                        principalTable: "Cung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UK_BacXepHang_MaBacXepHang",
                table: "BacXepHang",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cung_AnToanVeSinhVien",
                table: "Cung",
                column: "AnToanVeSinhVien");

            migrationBuilder.CreateIndex(
                name: "IX_Cung_CongDoanVien",
                table: "Cung",
                column: "CongDoanVien");

            migrationBuilder.CreateIndex(
                name: "IX_Cung_CungPho",
                table: "Cung",
                column: "CungPho");

            migrationBuilder.CreateIndex(
                name: "IX_Cung_CungTruong",
                table: "Cung",
                column: "CungTruong");

            migrationBuilder.CreateIndex(
                name: "UK_Cung_MaCung",
                table: "Cung",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ga_CungId",
                table: "Ga",
                column: "CungId");

            migrationBuilder.CreateIndex(
                name: "UK_Ga_MaGa",
                table: "Ga",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_LoaiTaiKhoan_MaLoaiTaiKhoan",
                table: "LoaiTaiKhoan",
                column: "Ma");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_BacXepHangId",
                table: "NhanVien",
                column: "BacXepHangId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_CungId",
                table: "NhanVien",
                column: "CungId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_LoaiTaiKhoanId",
                table: "NhanVien",
                column: "LoaiTaiKhoanId");

            migrationBuilder.CreateIndex(
                name: "UK_NhanVien_MaNhanVien",
                table: "NhanVien",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_PhongId",
                table: "NhanVien",
                column: "PhongId");

            migrationBuilder.CreateIndex(
                name: "UK_Phong_MaPhong",
                table: "Phong",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phong_PhoPhong",
                table: "Phong",
                column: "PhoPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_TruongPhong",
                table: "Phong",
                column: "TruongPhong");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_Cung",
                table: "NhanVien",
                column: "CungId",
                principalTable: "Cung",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_Phong",
                table: "NhanVien",
                column: "PhongId",
                principalTable: "Phong",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnToanVeSinhVien_NhanVien",
                table: "Cung");

            migrationBuilder.DropForeignKey(
                name: "FK_ConDoanVien_NhanVien",
                table: "Cung");

            migrationBuilder.DropForeignKey(
                name: "FK_CungPho_NhanVien",
                table: "Cung");

            migrationBuilder.DropForeignKey(
                name: "FK_CungTruong_NhanVien",
                table: "Cung");

            migrationBuilder.DropForeignKey(
                name: "FK_Phong_NhanVien",
                table: "Phong");

            migrationBuilder.DropForeignKey(
                name: "FK_TruongPhong_NhanVien",
                table: "Phong");

            migrationBuilder.DropTable(
                name: "Ga");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "BacXepHang");

            migrationBuilder.DropTable(
                name: "Cung");

            migrationBuilder.DropTable(
                name: "LoaiTaiKhoan");

            migrationBuilder.DropTable(
                name: "Phong");
        }
    }
}
