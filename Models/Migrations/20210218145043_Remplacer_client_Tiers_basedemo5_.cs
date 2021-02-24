using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class Remplacer_client_Tiers_basedemo5_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 18, 15, 50, 42, 969, DateTimeKind.Local).AddTicks(6562),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 18, 15, 43, 43, 627, DateTimeKind.Local).AddTicks(8492));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 18, 15, 43, 43, 627, DateTimeKind.Local).AddTicks(8492),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 18, 15, 50, 42, 969, DateTimeKind.Local).AddTicks(6562));
        }
    }
}
