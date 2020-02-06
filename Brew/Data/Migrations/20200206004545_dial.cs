using Microsoft.EntityFrameworkCore.Migrations;

namespace Brew.Data.Migrations
{
    public partial class dial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origin = table.Column<string>(nullable: true),
                    Roaster = table.Column<string>(nullable: true),
                    Grind = table.Column<double>(nullable: false),
                    Dose = table.Column<double>(nullable: false),
                    Body = table.Column<string>(nullable: true),
                    Extraction = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
