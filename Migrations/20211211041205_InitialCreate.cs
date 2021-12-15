using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeBuilderFinalProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecipeModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrepTime = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    RecipeName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    RecipeDescription = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeModels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeModels");
        }
    }
}
