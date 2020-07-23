using Microsoft.EntityFrameworkCore.Migrations;

namespace BinhTriThienQuanLyNhanSu.Migrations
{
    public partial class AllowBacXepHangNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BacXepHangId",
                table: "NhanVien",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BacXepHangId",
                table: "NhanVien",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
