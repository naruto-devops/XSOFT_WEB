using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class elimination_defalutValue_Type_tableTiers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 26, 14, 41, 59, 322, DateTimeKind.Local).AddTicks(6283),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 26, 12, 21, 39, 765, DateTimeKind.Local).AddTicks(7190));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 26, 12, 21, 39, 765, DateTimeKind.Local).AddTicks(7190),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 26, 14, 41, 59, 322, DateTimeKind.Local).AddTicks(6283));
        }
    }
}
