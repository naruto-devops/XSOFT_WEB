using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class modification_table_Taxe_IntToSens_Taux_Type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 3, 10, 1, 8, 745, DateTimeKind.Local).AddTicks(8802),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 1, 15, 54, 52, 285, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ClassificationArticles",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ClassificationArticles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 15, 54, 52, 285, DateTimeKind.Local).AddTicks(7761),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 3, 10, 1, 8, 745, DateTimeKind.Local).AddTicks(8802));
        }
    }
}
