using Microsoft.EntityFrameworkCore.Migrations;

namespace BinhTriThienQuanLyNhanSu.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BacXepHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaBacXepHang = table.Column<string>(maxLength: 10, nullable: false),
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
                    MaLoaiTaiKhoan = table.Column<string>(maxLength: 10, nullable: false),
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
                    MaNhanVien = table.Column<string>(maxLength: 10, nullable: false),
                    MatKhau = table.Column<string>(maxLength: 50, nullable: false),
                    Ho = table.Column<string>(maxLength: 50, nullable: false),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    DienThoaiDiDong = table.Column<string>(maxLength: 50, nullable: true),
                    DienThoaiCoDinh = table.Column<string>(maxLength: 50, nullable: true),
                    LoaiTaiKhoanId = table.Column<int>(nullable: false),
                    BacXepHangId = table.Column<int>(nullable: true)
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
                    MaCung = table.Column<string>(maxLength: 10, nullable: false),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    CungTruong = table.Column<int>(nullable: false),
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
                    MaPhong = table.Column<string>(maxLength: 10, nullable: false),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    TruongPhong = table.Column<int>(nullable: false),
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
                    MaGa = table.Column<string>(maxLength: 10, nullable: false),
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
                column: "MaBacXepHang",
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
                column: "MaCung",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ga_CungId",
                table: "Ga",
                column: "CungId");

            migrationBuilder.CreateIndex(
                name: "UK_Ga_MaGa",
                table: "Ga",
                column: "MaGa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_LoaiTaiKhoan_MaLoaiTaiKhoan",
                table: "LoaiTaiKhoan",
                column: "MaLoaiTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_BacXepHangId",
                table: "NhanVien",
                column: "BacXepHangId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_LoaiTaiKhoanId",
                table: "NhanVien",
                column: "LoaiTaiKhoanId");

            migrationBuilder.CreateIndex(
                name: "UK_NhanVien_MaNhanVien",
                table: "NhanVien",
                column: "MaNhanVien",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Phong_MaPhong",
                table: "Phong",
                column: "MaPhong",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phong_PhoPhong",
                table: "Phong",
                column: "PhoPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_TruongPhong",
                table: "Phong",
                column: "TruongPhong");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ga");

            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "Cung");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "BacXepHang");

            migrationBuilder.DropTable(
                name: "LoaiTaiKhoan");
        }
    }
}
