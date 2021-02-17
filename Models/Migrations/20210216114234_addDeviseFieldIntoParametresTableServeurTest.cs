using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class addDeviseFieldIntoParametresTableServeurTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 16, 12, 42, 34, 1, DateTimeKind.Local).AddTicks(7850),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 16, 12, 38, 9, 679, DateTimeKind.Local).AddTicks(664));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 16, 12, 38, 9, 679, DateTimeKind.Local).AddTicks(664),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 16, 12, 42, 34, 1, DateTimeKind.Local).AddTicks(7850));
        }
    }
}
