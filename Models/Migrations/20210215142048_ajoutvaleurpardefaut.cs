using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajoutvaleurpardefaut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Clients",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "Timbre",
                table: "Clients",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<double>(
                name: "TauxRemise",
                table: "Clients",
                maxLength: 18,
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<bool>(
                name: "Sommeil",
                table: "Clients",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "NumeroBanqueTier",
                table: "Clients",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "Etranger",
                table: "Clients",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<double>(
                name: "Encours",
                table: "Clients",
                maxLength: 24,
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldMaxLength: 24);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 15, 15, 20, 48, 791, DateTimeKind.Local).AddTicks(8330),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<double>(
                name: "CoursDevise",
                table: "Clients",
                maxLength: 18,
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldMaxLength: 18);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "Timbre",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<double>(
                name: "TauxRemise",
                table: "Clients",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(double),
                oldMaxLength: 18,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<bool>(
                name: "Sommeil",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "NumeroBanqueTier",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "Etranger",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<double>(
                name: "Encours",
                table: "Clients",
                maxLength: 24,
                nullable: false,
                oldClrType: typeof(double),
                oldMaxLength: 24,
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 15, 15, 20, 48, 791, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.AlterColumn<double>(
                name: "CoursDevise",
                table: "Clients",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(double),
                oldMaxLength: 18,
                oldDefaultValue: 0.0);
        }
    }
}
