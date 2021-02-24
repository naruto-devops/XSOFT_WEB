using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class recreerParametres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 19, 12, 9, 22, 228, DateTimeKind.Local).AddTicks(4021),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 19, 11, 57, 49, 584, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.AlterColumn<string>(
                name: "FournisseurGen",
                table: "Parametres",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 13,
                oldNullable: true,
                oldDefaultValue: "40100000");

            migrationBuilder.AlterColumn<string>(
                name: "ClientGen",
                table: "Parametres",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 13,
                oldNullable: true,
                oldDefaultValue: "411000");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 19, 11, 57, 49, 584, DateTimeKind.Local).AddTicks(1338),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 19, 12, 9, 22, 228, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.AlterColumn<string>(
                name: "FournisseurGen",
                table: "Parametres",
                maxLength: 13,
                nullable: true,
                defaultValue: "40100000",
                oldClrType: typeof(string),
                oldMaxLength: 13,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientGen",
                table: "Parametres",
                maxLength: 13,
                nullable: true,
                defaultValue: "411000",
                oldClrType: typeof(string),
                oldMaxLength: 13,
                oldNullable: true);
        }
    }
}
