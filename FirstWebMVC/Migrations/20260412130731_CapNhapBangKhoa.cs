using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FirstWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class CapNhapBangKhoa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Khoas",
                columns: new[] { "MaKhoa", "TenKhoa" },
                values: new object[,]
                {
                    { "CD", "Cơ điện" },
                    { "CNTT", "Công nghệ thông tin" },
                    { "KETOAN", "Kế toán" },
                    { "QTKD", "Quản trị kinh doanh" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Khoas",
                keyColumn: "MaKhoa",
                keyValue: "CD");

            migrationBuilder.DeleteData(
                table: "Khoas",
                keyColumn: "MaKhoa",
                keyValue: "CNTT");

            migrationBuilder.DeleteData(
                table: "Khoas",
                keyColumn: "MaKhoa",
                keyValue: "KETOAN");

            migrationBuilder.DeleteData(
                table: "Khoas",
                keyColumn: "MaKhoa",
                keyValue: "QTKD");
        }
    }
}
