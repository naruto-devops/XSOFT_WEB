using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajoutChampExonereTVA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategorieComptabilite",
                table: "Clients");

            migrationBuilder.AddColumn<bool>(
                name: "ExonereTVA",
                table: "Clients",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExonereTVA",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "CategorieComptabilite",
                table: "Clients",
                nullable: false,
                defaultValue: 0);
        }
    }
}
