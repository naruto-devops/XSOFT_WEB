using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class addFieldTiersGenParametres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TiersGen",
                table: "Parametres",
                maxLength: 13,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TiersGen",
                table: "Parametres");
        }
    }
}
