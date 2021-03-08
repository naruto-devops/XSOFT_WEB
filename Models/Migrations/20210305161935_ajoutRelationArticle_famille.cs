using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajoutRelationArticle_famille : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 5, 17, 19, 35, 568, DateTimeKind.Local).AddTicks(866),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 4, 15, 8, 18, 456, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.AddColumn<int>(
                name: "FamilleId",
                table: "ArticlesGeneriques",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesGeneriques_FamilleId",
                table: "ArticlesGeneriques",
                column: "FamilleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticlesGeneriques_Famille_FamilleId",
                table: "ArticlesGeneriques",
                column: "FamilleId",
                principalTable: "Famille",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticlesGeneriques_Famille_FamilleId",
                table: "ArticlesGeneriques");

            migrationBuilder.DropIndex(
                name: "IX_ArticlesGeneriques_FamilleId",
                table: "ArticlesGeneriques");

            migrationBuilder.DropColumn(
                name: "FamilleId",
                table: "ArticlesGeneriques");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 15, 8, 18, 456, DateTimeKind.Local).AddTicks(3429),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 5, 17, 19, 35, 568, DateTimeKind.Local).AddTicks(866));
        }
    }
}
