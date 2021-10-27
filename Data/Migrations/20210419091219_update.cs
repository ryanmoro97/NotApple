using Microsoft.EntityFrameworkCore.Migrations;

namespace part4.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cpu2",
                table: "Computer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Display2",
                table: "Computer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gpu2",
                table: "Computer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OS2",
                table: "Computer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OS3",
                table: "Computer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ram2",
                table: "Computer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ram3",
                table: "Computer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Storage2",
                table: "Computer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Storage3",
                table: "Computer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Cpu = table.Column<string>(nullable: true),
                    Ram = table.Column<string>(nullable: true),
                    Storage = table.Column<string>(nullable: true),
                    Display = table.Column<string>(nullable: true),
                    Gpu = table.Column<string>(nullable: true),
                    OS = table.Column<string>(nullable: true),
                    Total = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropColumn(
                name: "Cpu2",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "Display2",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "Gpu2",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "OS2",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "OS3",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "Ram2",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "Ram3",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "Storage2",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "Storage3",
                table: "Computer");
        }
    }
}
