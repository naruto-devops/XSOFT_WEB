using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajoutchampDeleted_tableDimension_detailDimension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Tiers",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 26, 12, 21, 39, 765, DateTimeKind.Local).AddTicks(7190),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 26, 10, 41, 14, 31, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Dimensions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "DetailDimensions",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Dimensions");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "DetailDimensions");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Tiers",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 26, 10, 41, 14, 31, DateTimeKind.Local).AddTicks(6063),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 26, 12, 21, 39, 765, DateTimeKind.Local).AddTicks(7190));
        }
    }
}
