using Microsoft.EntityFrameworkCore.Migrations;

namespace START.Data.Migrations
{
    public partial class xyz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) //tạo bảng
        {
            migrationBuilder.AddColumn<int>(
                name: "numberSinhVien",
                table: "Lop",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder) //xóa bảng
        {
            migrationBuilder.DropColumn(
                name: "numberSinhVien",
                table: "Lop");
        }
    }
}
