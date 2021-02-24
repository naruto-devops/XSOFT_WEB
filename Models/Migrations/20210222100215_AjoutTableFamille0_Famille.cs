using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class AjoutTableFamille0_Famille : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EProtections_Utilisateurs_UtilisateurID",
                table: "EProtections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EProtections",
                table: "EProtections");

            migrationBuilder.RenameTable(
                name: "EProtections",
                newName: "EProtection");

            migrationBuilder.RenameIndex(
                name: "IX_EProtections_UtilisateurID",
                table: "EProtection",
                newName: "IX_EProtection_UtilisateurID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 22, 11, 2, 15, 49, DateTimeKind.Local).AddTicks(422),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 19, 12, 11, 27, 706, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.AddPrimaryKey(
                name: "PK_EProtection",
                table: "EProtection",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Famille0",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 19, nullable: true),
                    Intitule = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Famille0", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Famille",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodeFamille = table.Column<string>(maxLength: 19, nullable: true),
                    Intitule = table.Column<string>(maxLength: 40, nullable: true),
                    SuiviStock = table.Column<int>(nullable: false),
                    Remise = table.Column<double>(nullable: false),
                    TaxeVente1 = table.Column<int>(nullable: false),
                    TaxeAchat1 = table.Column<int>(nullable: false),
                    TaxeVente2 = table.Column<int>(nullable: false),
                    TaxeAchat2 = table.Column<int>(nullable: false),
                    Famille0Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Famille", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Famille_Famille0_Famille0Id",
                        column: x => x.Famille0Id,
                        principalTable: "Famille0",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UnicityCodeFamille",
                table: "Famille",
                column: "CodeFamille",
                unique: true,
                filter: "[CodeFamille] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Famille_Famille0Id",
                table: "Famille",
                column: "Famille0Id");

            migrationBuilder.CreateIndex(
                name: "UnicityCODE",
                table: "Famille0",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_EProtection_Utilisateurs_UtilisateurID",
                table: "EProtection",
                column: "UtilisateurID",
                principalTable: "Utilisateurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EProtection_Utilisateurs_UtilisateurID",
                table: "EProtection");

            migrationBuilder.DropTable(
                name: "Famille");

            migrationBuilder.DropTable(
                name: "Famille0");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EProtection",
                table: "EProtection");

            migrationBuilder.RenameTable(
                name: "EProtection",
                newName: "EProtections");

            migrationBuilder.RenameIndex(
                name: "IX_EProtection_UtilisateurID",
                table: "EProtections",
                newName: "IX_EProtections_UtilisateurID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 19, 12, 11, 27, 706, DateTimeKind.Local).AddTicks(7993),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 22, 11, 2, 15, 49, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.AddPrimaryKey(
                name: "PK_EProtections",
                table: "EProtections",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_EProtections_Utilisateurs_UtilisateurID",
                table: "EProtections",
                column: "UtilisateurID",
                principalTable: "Utilisateurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
