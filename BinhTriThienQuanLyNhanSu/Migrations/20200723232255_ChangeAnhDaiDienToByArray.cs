using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BinhTriThienQuanLyNhanSu.Migrations
{
    public partial class ChangeAnhDaiDienToByArray : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "AnhDaiDien",
                table: "NhanVien",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AnhDaiDien",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);
        }
    }
}
