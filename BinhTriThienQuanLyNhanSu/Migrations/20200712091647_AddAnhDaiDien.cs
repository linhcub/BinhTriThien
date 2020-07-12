using Microsoft.EntityFrameworkCore.Migrations;

namespace BinhTriThienQuanLyNhanSu.Migrations
{
    public partial class AddAnhDaiDien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnhDaiDien",
                table: "NhanVien",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnhDaiDien",
                table: "NhanVien");
        }
    }
}
