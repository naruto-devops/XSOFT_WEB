using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajoutTableUnite_Taxe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EProtection_Utilisateurs_UtilisateurID",
                table: "EProtection");

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
                defaultValue: new DateTime(2021, 2, 23, 16, 3, 50, 27, DateTimeKind.Local).AddTicks(6800),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 22, 11, 2, 15, 49, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.AddColumn<int>(
                name: "UniteId",
                table: "Famille",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EProtections",
                table: "EProtections",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Taxes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Intitule = table.Column<string>(maxLength: 35, nullable: true),
                    TTaux = table.Column<bool>(nullable: false),
                    Type = table.Column<bool>(nullable: false),
                    CompteComptable = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    NonProfitaire = table.Column<bool>(nullable: false),
                    Sens = table.Column<bool>(nullable: false),
                    Regroup = table.Column<string>(nullable: true),
                    Assujet = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Unites",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Libelle = table.Column<string>(maxLength: 30, nullable: true),
                    UniteID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unites", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Unites_Unites_UniteID",
                        column: x => x.UniteID,
                        principalTable: "Unites",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Famille_UniteId",
                table: "Famille",
                column: "UniteId");

            migrationBuilder.CreateIndex(
                name: "UnicityCodeTaxe",
                table: "Taxes",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UnicityLibelle",
                table: "Unites",
                column: "Libelle",
                unique: true,
                filter: "[Libelle] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Unites_UniteID",
                table: "Unites",
                column: "UniteID");

            migrationBuilder.AddForeignKey(
                name: "FK_EProtections_Utilisateurs_UtilisateurID",
                table: "EProtections",
                column: "UtilisateurID",
                principalTable: "Utilisateurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Famille_Unites_UniteId",
                table: "Famille",
                column: "UniteId",
                principalTable: "Unites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EProtections_Utilisateurs_UtilisateurID",
                table: "EProtections");

            migrationBuilder.DropForeignKey(
                name: "FK_Famille_Unites_UniteId",
                table: "Famille");

            migrationBuilder.DropTable(
                name: "Taxes");

            migrationBuilder.DropTable(
                name: "Unites");

            migrationBuilder.DropIndex(
                name: "IX_Famille_UniteId",
                table: "Famille");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EProtections",
                table: "EProtections");

            migrationBuilder.DropColumn(
                name: "UniteId",
                table: "Famille");

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
                oldDefaultValue: new DateTime(2021, 2, 23, 16, 3, 50, 27, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.AddPrimaryKey(
                name: "PK_EProtection",
                table: "EProtection",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_EProtection_Utilisateurs_UtilisateurID",
                table: "EProtection",
                column: "UtilisateurID",
                principalTable: "Utilisateurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
