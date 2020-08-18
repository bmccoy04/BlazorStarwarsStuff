using Microsoft.EntityFrameworkCore.Migrations;

namespace StarwarsStuff.Api.Migrations
{
    public partial class addedplanets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageLocation = table.Column<string>(nullable: true),
                    Climate = table.Column<string>(nullable: true),
                    Inhabitants = table.Column<string>(nullable: true),
                    Sector = table.Column<string>(nullable: true),
                    System = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planets");
        }
    }
}
