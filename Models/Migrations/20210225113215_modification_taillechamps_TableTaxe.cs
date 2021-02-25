using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class modification_taillechamps_TableTaxe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 25, 12, 32, 15, 367, DateTimeKind.Local).AddTicks(1791),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 24, 15, 5, 49, 786, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.AlterColumn<string>(
                name: "Regroup",
                table: "Taxes",
                maxLength: 35,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompteComptable",
                table: "Taxes",
                maxLength: 35,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Taxes",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 24, 15, 5, 49, 786, DateTimeKind.Local).AddTicks(6246),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 25, 12, 32, 15, 367, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.AlterColumn<string>(
                name: "Regroup",
                table: "Taxes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 35,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompteComptable",
                table: "Taxes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 35,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Taxes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldNullable: true);
        }
    }
}
