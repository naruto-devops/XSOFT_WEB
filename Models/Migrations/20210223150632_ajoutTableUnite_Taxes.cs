using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajoutTableUnite_Taxes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Unites_Unites_UniteID",
                table: "Unites");

            migrationBuilder.DropIndex(
                name: "IX_Unites_UniteID",
                table: "Unites");

            migrationBuilder.DropColumn(
                name: "UniteID",
                table: "Unites");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 23, 16, 6, 32, 391, DateTimeKind.Local).AddTicks(7928),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 23, 16, 3, 50, 27, DateTimeKind.Local).AddTicks(6800));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UniteID",
                table: "Unites",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 23, 16, 3, 50, 27, DateTimeKind.Local).AddTicks(6800),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 23, 16, 6, 32, 391, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.CreateIndex(
                name: "IX_Unites_UniteID",
                table: "Unites",
                column: "UniteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Unites_Unites_UniteID",
                table: "Unites",
                column: "UniteID",
                principalTable: "Unites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
