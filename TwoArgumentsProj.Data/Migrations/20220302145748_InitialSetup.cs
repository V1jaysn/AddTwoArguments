using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwoArgumentsProj.Data.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArgumentResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Arg1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arg2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArgumentResults", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArgumentResults");
        }
    }
}
