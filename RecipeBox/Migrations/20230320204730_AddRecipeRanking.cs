using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBox.Migrations
{
    public partial class AddRecipeRanking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ranking",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ranking",
                table: "Recipes");
        }
    }
}
