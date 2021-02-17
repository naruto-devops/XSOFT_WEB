using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class addDeviseFieldIntoParametresTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ClientGen",
                table: "Parametres",
                maxLength: 17,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 13,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Devise",
                table: "Parametres",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 16, 12, 38, 9, 679, DateTimeKind.Local).AddTicks(664),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 15, 16, 10, 8, 544, DateTimeKind.Local).AddTicks(6141));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Devise",
                table: "Parametres");

            migrationBuilder.AlterColumn<string>(
                name: "ClientGen",
                table: "Parametres",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 17,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 15, 16, 10, 8, 544, DateTimeKind.Local).AddTicks(6141),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 16, 12, 38, 9, 679, DateTimeKind.Local).AddTicks(664));
        }
    }
}
