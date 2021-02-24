using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajoutChampExonereTVA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategorieComptabilite",
                table: "Tierss");

            migrationBuilder.AddColumn<bool>(
                name: "ExonereTVA",
                table: "Tierss",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExonereTVA",
                table: "Tierss");

            migrationBuilder.AddColumn<int>(
                name: "CategorieComptabilite",
                table: "Tierss",
                nullable: false,
                defaultValue: 0);
        }
    }
}
