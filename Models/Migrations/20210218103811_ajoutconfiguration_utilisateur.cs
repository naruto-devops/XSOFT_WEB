using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajoutconfiguration_utilisateur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "User",
                table: "Utilisateurs",
                maxLength: 35,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModePasse",
                table: "Utilisateurs",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Utilisateurs",
                maxLength: 35,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "C_ModePasse",
                table: "Utilisateurs",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 18, 11, 38, 10, 994, DateTimeKind.Local).AddTicks(2975),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 16, 12, 42, 34, 1, DateTimeKind.Local).AddTicks(7850));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "User",
                table: "Utilisateurs",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 35,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModePasse",
                table: "Utilisateurs",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Utilisateurs",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 35,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "C_ModePasse",
                table: "Utilisateurs",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 16, 12, 42, 34, 1, DateTimeKind.Local).AddTicks(7850),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 18, 11, 38, 10, 994, DateTimeKind.Local).AddTicks(2975));
        }
    }
}
