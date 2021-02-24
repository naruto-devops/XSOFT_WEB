using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajoutrelationFamille_Taxe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaxeAchat1",
                table: "Famille");

            migrationBuilder.DropColumn(
                name: "TaxeAchat2",
                table: "Famille");

            migrationBuilder.DropColumn(
                name: "TaxeVente1",
                table: "Famille");

            migrationBuilder.DropColumn(
                name: "TaxeVente2",
                table: "Famille");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 23, 17, 25, 37, 454, DateTimeKind.Local).AddTicks(3910),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 23, 16, 6, 32, 391, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.AddColumn<int>(
                name: "TaxeAchatId",
                table: "Famille",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxeVenteId",
                table: "Famille",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Famille_TaxeAchatId",
                table: "Famille",
                column: "TaxeAchatId");

            migrationBuilder.CreateIndex(
                name: "IX_Famille_TaxeVenteId",
                table: "Famille",
                column: "TaxeVenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Famille_Taxes_TaxeAchatId",
                table: "Famille",
                column: "TaxeAchatId",
                principalTable: "Taxes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Famille_Taxes_TaxeVenteId",
                table: "Famille",
                column: "TaxeVenteId",
                principalTable: "Taxes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Famille_Taxes_TaxeAchatId",
                table: "Famille");

            migrationBuilder.DropForeignKey(
                name: "FK_Famille_Taxes_TaxeVenteId",
                table: "Famille");

            migrationBuilder.DropIndex(
                name: "IX_Famille_TaxeAchatId",
                table: "Famille");

            migrationBuilder.DropIndex(
                name: "IX_Famille_TaxeVenteId",
                table: "Famille");

            migrationBuilder.DropColumn(
                name: "TaxeAchatId",
                table: "Famille");

            migrationBuilder.DropColumn(
                name: "TaxeVenteId",
                table: "Famille");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 23, 16, 6, 32, 391, DateTimeKind.Local).AddTicks(7928),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 23, 17, 25, 37, 454, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.AddColumn<int>(
                name: "TaxeAchat1",
                table: "Famille",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaxeAchat2",
                table: "Famille",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaxeVente1",
                table: "Famille",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaxeVente2",
                table: "Famille",
                nullable: false,
                defaultValue: 0);
        }
    }
}
