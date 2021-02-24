using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajoutDeletedfield_taxe_Unite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Unites",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 24, 15, 5, 49, 786, DateTimeKind.Local).AddTicks(6246),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 24, 14, 56, 21, 321, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Taxes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Unites");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Taxes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 24, 14, 56, 21, 321, DateTimeKind.Local).AddTicks(2530),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 24, 15, 5, 49, 786, DateTimeKind.Local).AddTicks(6246));
        }
    }
}
