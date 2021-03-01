using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class modificationchamps_tableTaxe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 12, 37, 45, 130, DateTimeKind.Local).AddTicks(263),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 26, 14, 41, 59, 322, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Taxes",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "TTaux",
                table: "Taxes",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "Sens",
                table: "Taxes",
                nullable: false,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 26, 14, 41, 59, 322, DateTimeKind.Local).AddTicks(6283),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 1, 12, 37, 45, 130, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.AlterColumn<bool>(
                name: "Type",
                table: "Taxes",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "TTaux",
                table: "Taxes",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "Sens",
                table: "Taxes",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
