using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajoutTaux_tableTaxe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 3, 14, 51, 50, 974, DateTimeKind.Local).AddTicks(1592),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 3, 10, 1, 8, 745, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.AddColumn<double>(
                name: "Taux",
                table: "Taxes",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Taux",
                table: "Taxes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 3, 10, 1, 8, 745, DateTimeKind.Local).AddTicks(8802),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 3, 14, 51, 50, 974, DateTimeKind.Local).AddTicks(1592));
        }
    }
}
