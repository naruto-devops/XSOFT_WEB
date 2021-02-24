using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class Remplacer_client_Tiers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Tierss_TiersID",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tierss_Utilisateurs_CREATEURId",
                table: "Tierss");

            migrationBuilder.DropForeignKey(
                name: "FK_Tierss_CategorieTarifs_CategorieTarifId",
                table: "Tierss");

            migrationBuilder.DropForeignKey(
                name: "FK_Tierss_Collaborateurs_CollaborateurId",
                table: "Tierss");

            migrationBuilder.DropForeignKey(
                name: "FK_Tierss_Devises_DeviseId",
                table: "Tierss");

            migrationBuilder.DropForeignKey(
                name: "FK_Tierss_FamilleTiers_FamilleTierId",
                table: "Tierss");

            migrationBuilder.DropForeignKey(
                name: "FK_Tierss_Utilisateurs_MODIFICATEURId",
                table: "Tierss");

            migrationBuilder.DropForeignKey(
                name: "FK_Tierss_ModalitePaiements_ModalitePaiementId",
                table: "Tierss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tierss",
                table: "Tierss");

            migrationBuilder.DropColumn(
                name: "TierstId",
                table: "Contacts");

            migrationBuilder.RenameTable(
                name: "Tierss",
                newName: "Tiers");

            migrationBuilder.RenameColumn(
                name: "TiersID",
                table: "Contacts",
                newName: "TiersId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_TiersID",
                table: "Contacts",
                newName: "IX_Contacts_TiersId");

            migrationBuilder.RenameIndex(
                name: "IX_Tierss_ModalitePaiementId",
                table: "Tiers",
                newName: "IX_Tiers_ModalitePaiementId");

            migrationBuilder.RenameIndex(
                name: "IX_Tierss_MODIFICATEURId",
                table: "Tiers",
                newName: "IX_Tiers_MODIFICATEURId");

            migrationBuilder.RenameIndex(
                name: "IX_Tierss_FamilleTierId",
                table: "Tiers",
                newName: "IX_Tiers_FamilleTierId");

            migrationBuilder.RenameIndex(
                name: "IX_Tierss_DeviseId",
                table: "Tiers",
                newName: "IX_Tiers_DeviseId");

            migrationBuilder.RenameIndex(
                name: "IX_Tierss_CollaborateurId",
                table: "Tiers",
                newName: "IX_Tiers_CollaborateurId");

            migrationBuilder.RenameIndex(
                name: "IX_Tierss_CategorieTarifId",
                table: "Tiers",
                newName: "IX_Tiers_CategorieTarifId");

            migrationBuilder.RenameIndex(
                name: "IX_Tierss_CREATEURId",
                table: "Tiers",
                newName: "IX_Tiers_CREATEURId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 18, 15, 42, 39, 816, DateTimeKind.Local).AddTicks(4486),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 18, 11, 38, 10, 994, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tiers",
                table: "Tiers",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Tiers_TiersId",
                table: "Contacts",
                column: "TiersId",
                principalTable: "Tiers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiers_Utilisateurs_CREATEURId",
                table: "Tiers",
                column: "CREATEURId",
                principalTable: "Utilisateurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiers_CategorieTarifs_CategorieTarifId",
                table: "Tiers",
                column: "CategorieTarifId",
                principalTable: "CategorieTarifs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiers_Collaborateurs_CollaborateurId",
                table: "Tiers",
                column: "CollaborateurId",
                principalTable: "Collaborateurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiers_Devises_DeviseId",
                table: "Tiers",
                column: "DeviseId",
                principalTable: "Devises",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiers_FamilleTiers_FamilleTierId",
                table: "Tiers",
                column: "FamilleTierId",
                principalTable: "FamilleTiers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiers_Utilisateurs_MODIFICATEURId",
                table: "Tiers",
                column: "MODIFICATEURId",
                principalTable: "Utilisateurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tiers_ModalitePaiements_ModalitePaiementId",
                table: "Tiers",
                column: "ModalitePaiementId",
                principalTable: "ModalitePaiements",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Tiers_TiersId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiers_Utilisateurs_CREATEURId",
                table: "Tiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiers_CategorieTarifs_CategorieTarifId",
                table: "Tiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiers_Collaborateurs_CollaborateurId",
                table: "Tiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiers_Devises_DeviseId",
                table: "Tiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiers_FamilleTiers_FamilleTierId",
                table: "Tiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiers_Utilisateurs_MODIFICATEURId",
                table: "Tiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tiers_ModalitePaiements_ModalitePaiementId",
                table: "Tiers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tiers",
                table: "Tiers");

            migrationBuilder.RenameTable(
                name: "Tiers",
                newName: "Tierss");

            migrationBuilder.RenameColumn(
                name: "TiersId",
                table: "Contacts",
                newName: "TiersID");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_TiersId",
                table: "Contacts",
                newName: "IX_Contacts_TiersID");

            migrationBuilder.RenameIndex(
                name: "IX_Tiers_ModalitePaiementId",
                table: "Tierss",
                newName: "IX_Tierss_ModalitePaiementId");

            migrationBuilder.RenameIndex(
                name: "IX_Tiers_MODIFICATEURId",
                table: "Tierss",
                newName: "IX_Tierss_MODIFICATEURId");

            migrationBuilder.RenameIndex(
                name: "IX_Tiers_FamilleTierId",
                table: "Tierss",
                newName: "IX_Tierss_FamilleTierId");

            migrationBuilder.RenameIndex(
                name: "IX_Tiers_DeviseId",
                table: "Tierss",
                newName: "IX_Tierss_DeviseId");

            migrationBuilder.RenameIndex(
                name: "IX_Tiers_CollaborateurId",
                table: "Tierss",
                newName: "IX_Tierss_CollaborateurId");

            migrationBuilder.RenameIndex(
                name: "IX_Tiers_CategorieTarifId",
                table: "Tierss",
                newName: "IX_Tierss_CategorieTarifId");

            migrationBuilder.RenameIndex(
                name: "IX_Tiers_CREATEURId",
                table: "Tierss",
                newName: "IX_Tierss_CREATEURId");

            migrationBuilder.AddColumn<int>(
                name: "TierstId",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tierss",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 18, 11, 38, 10, 994, DateTimeKind.Local).AddTicks(2975),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 18, 15, 42, 39, 816, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tierss",
                table: "Tierss",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Tierss_TiersID",
                table: "Contacts",
                column: "TiersID",
                principalTable: "Tierss",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tierss_Utilisateurs_CREATEURId",
                table: "Tierss",
                column: "CREATEURId",
                principalTable: "Utilisateurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tierss_CategorieTarifs_CategorieTarifId",
                table: "Tierss",
                column: "CategorieTarifId",
                principalTable: "CategorieTarifs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tierss_Collaborateurs_CollaborateurId",
                table: "Tierss",
                column: "CollaborateurId",
                principalTable: "Collaborateurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tierss_Devises_DeviseId",
                table: "Tierss",
                column: "DeviseId",
                principalTable: "Devises",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tierss_FamilleTiers_FamilleTierId",
                table: "Tierss",
                column: "FamilleTierId",
                principalTable: "FamilleTiers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tierss_Utilisateurs_MODIFICATEURId",
                table: "Tierss",
                column: "MODIFICATEURId",
                principalTable: "Utilisateurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tierss_ModalitePaiements_ModalitePaiementId",
                table: "Tierss",
                column: "ModalitePaiementId",
                principalTable: "ModalitePaiements",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
