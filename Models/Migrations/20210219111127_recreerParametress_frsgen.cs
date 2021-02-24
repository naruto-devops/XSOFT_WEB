using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class recreerParametress_frsgen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 19, 12, 11, 27, 706, DateTimeKind.Local).AddTicks(7993),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 19, 12, 9, 22, 228, DateTimeKind.Local).AddTicks(4021));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 19, 12, 9, 22, 228, DateTimeKind.Local).AddTicks(4021),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 19, 12, 11, 27, 706, DateTimeKind.Local).AddTicks(7993));
        }
    }
}
