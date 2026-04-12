using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddBangKhoa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Students",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StudentCode",
                table: "Students",
                type: "TEXT",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "MaKhoa",
                table: "Students",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Khoas",
                columns: table => new
                {
                    MaKhoa = table.Column<string>(type: "TEXT", nullable: false),
                    TenKhoa = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoas", x => x.MaKhoa);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_MaKhoa",
                table: "Students",
                column: "MaKhoa");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Khoas_MaKhoa",
                table: "Students",
                column: "MaKhoa",
                principalTable: "Khoas",
                principalColumn: "MaKhoa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Khoas_MaKhoa",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Khoas");

            migrationBuilder.DropIndex(
                name: "IX_Students_MaKhoa",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MaKhoa",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Students",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "StudentCode",
                table: "Students",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 10)
                .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
