using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajouttableEProtectionServeur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tierss",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 15, 16, 10, 8, 544, DateTimeKind.Local).AddTicks(6141),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 15, 15, 30, 46, 404, DateTimeKind.Local).AddTicks(1109));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tierss",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 15, 15, 30, 46, 404, DateTimeKind.Local).AddTicks(1109),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 15, 16, 10, 8, 544, DateTimeKind.Local).AddTicks(6141));
        }
    }
}
