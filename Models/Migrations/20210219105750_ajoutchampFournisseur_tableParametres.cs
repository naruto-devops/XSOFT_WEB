using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajoutchampFournisseur_tableParametres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TiersGen",
                table: "Parametres");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 19, 11, 57, 49, 584, DateTimeKind.Local).AddTicks(1338),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 18, 15, 50, 42, 969, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.AddColumn<string>(
                name: "ClientGen",
                table: "Parametres",
                maxLength: 13,
                nullable: true,
                defaultValue: "411000");

            migrationBuilder.AddColumn<string>(
                name: "FournisseurGen",
                table: "Parametres",
                maxLength: 13,
                nullable: true,
                defaultValue: "40100000");

            migrationBuilder.AlterColumn<bool>(
                name: "Deleted",
                table: "Contacts",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientGen",
                table: "Parametres");

            migrationBuilder.DropColumn(
                name: "FournisseurGen",
                table: "Parametres");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 18, 15, 50, 42, 969, DateTimeKind.Local).AddTicks(6562),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 19, 11, 57, 49, 584, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.AddColumn<string>(
                name: "TiersGen",
                table: "Parametres",
                maxLength: 17,
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Deleted",
                table: "Contacts",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));
        }
    }
}
