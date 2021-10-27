using Microsoft.EntityFrameworkCore.Migrations;

namespace part4.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_Computer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computer");
        }
    }
}
