using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mvcmovie.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Demo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Person");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Person",
                newName: "Tuoi");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Person",
                newName: "QueQuan");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Person",
                newName: "Cancuocongdan");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                type: "TEXT",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GioiTinh",
                table: "Person",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HoTen",
                table: "Person",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Cancuocongdan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "GioiTinh",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "HoTen",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Employee");

            migrationBuilder.RenameColumn(
                name: "Tuoi",
                table: "Employee",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "QueQuan",
                table: "Employee",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "Cancuocongdan",
                table: "Employee",
                newName: "StudentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "StudentID");

            migrationBuilder.CreateTable(
                name: "Demo",
                columns: table => new
                {
                    StudentID = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    FullName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demo", x => x.StudentID);
                });
        }
    }
}
