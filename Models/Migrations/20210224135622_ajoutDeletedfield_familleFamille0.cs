using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajoutDeletedfield_familleFamille0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 24, 14, 56, 21, 321, DateTimeKind.Local).AddTicks(2530),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 23, 17, 25, 37, 454, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Famille0",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Famille",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Famille0");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Famille");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 23, 17, 25, 37, 454, DateTimeKind.Local).AddTicks(3910),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 24, 14, 56, 21, 321, DateTimeKind.Local).AddTicks(2530));
        }
    }
}
