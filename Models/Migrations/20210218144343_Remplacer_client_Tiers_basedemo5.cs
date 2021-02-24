using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class Remplacer_client_Tiers_basedemo5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 18, 15, 43, 43, 627, DateTimeKind.Local).AddTicks(8492),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 18, 15, 42, 39, 816, DateTimeKind.Local).AddTicks(4486));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 18, 15, 42, 39, 816, DateTimeKind.Local).AddTicks(4486),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 18, 15, 43, 43, 627, DateTimeKind.Local).AddTicks(8492));
        }
    }
}
