using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajouttablearticlegenerique_relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 15, 8, 18, 456, DateTimeKind.Local).AddTicks(3429),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 3, 14, 51, 50, 974, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.AddColumn<bool>(
                name: "INCART",
                table: "Parametres",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "INCARTFAM",
                table: "Parametres",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NUMART",
                table: "Parametres",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ArticlesGeneriques",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Reference = table.Column<string>(maxLength: 19, nullable: true),
                    Design = table.Column<string>(maxLength: 60, nullable: true),
                    Description = table.Column<string>(maxLength: 90, nullable: true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    DateModifiction = table.Column<DateTime>(nullable: false),
                    PrixAchat = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    Coefficient = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    PrixVente = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    PrixTTC = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    SuiviStock = table.Column<int>(nullable: false, defaultValue: 0),
                    CodeFiscal = table.Column<string>(nullable: true),
                    Pays = table.Column<string>(nullable: true),
                    PUNet = table.Column<decimal>(nullable: false),
                    NotImp = table.Column<bool>(nullable: false, defaultValue: false),
                    Remise = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    CodeBarre = table.Column<string>(nullable: true),
                    PrixAchatDernier = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    Sommeil = table.Column<bool>(nullable: false, defaultValue: false),
                    Conditionne = table.Column<bool>(nullable: false, defaultValue: false),
                    QteConditionne = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    ImageName = table.Column<string>(nullable: true),
                    TypeArticle = table.Column<int>(nullable: false, defaultValue: 0),
                    Statut = table.Column<int>(nullable: false, defaultValue: 0),
                    Jointe1 = table.Column<string>(nullable: true),
                    Jointe2 = table.Column<string>(nullable: true),
                    Poids = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    ReferenceFournisseur = table.Column<string>(nullable: true),
                    EMBALLAGE = table.Column<int>(nullable: false, defaultValue: 0),
                    STOCKMIN = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    FEINTEPROD = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    DELAIAPPRO = table.Column<int>(nullable: false, defaultValue: 0),
                    FEINTAPPRO = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    LOTENCOURS = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    TaxeVente1Id = table.Column<int>(nullable: true),
                    TaxeVente2Id = table.Column<int>(nullable: true),
                    TaxeAchat1Id = table.Column<int>(nullable: true),
                    TaxeAchat2Id = table.Column<int>(nullable: true),
                    CreateurId = table.Column<int>(nullable: true),
                    ModificateurId = table.Column<int>(nullable: true),
                    ClassificationArticleId = table.Column<int>(nullable: true),
                    UniteId = table.Column<int>(nullable: true),
                    Dimension1Id = table.Column<int>(nullable: true),
                    Dimension2Id = table.Column<int>(nullable: true),
                    FournisseurPrincipaleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlesGeneriques", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ArticlesGeneriques_ClassificationArticles_ClassificationArticleId",
                        column: x => x.ClassificationArticleId,
                        principalTable: "ClassificationArticles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticlesGeneriques_Utilisateurs_CreateurId",
                        column: x => x.CreateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticlesGeneriques_Dimensions_Dimension1Id",
                        column: x => x.Dimension1Id,
                        principalTable: "Dimensions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticlesGeneriques_Dimensions_Dimension2Id",
                        column: x => x.Dimension2Id,
                        principalTable: "Dimensions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticlesGeneriques_Tiers_FournisseurPrincipaleId",
                        column: x => x.FournisseurPrincipaleId,
                        principalTable: "Tiers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticlesGeneriques_Utilisateurs_ModificateurId",
                        column: x => x.ModificateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticlesGeneriques_Taxes_TaxeAchat1Id",
                        column: x => x.TaxeAchat1Id,
                        principalTable: "Taxes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticlesGeneriques_Taxes_TaxeAchat2Id",
                        column: x => x.TaxeAchat2Id,
                        principalTable: "Taxes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticlesGeneriques_Taxes_TaxeVente1Id",
                        column: x => x.TaxeVente1Id,
                        principalTable: "Taxes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticlesGeneriques_Taxes_TaxeVente2Id",
                        column: x => x.TaxeVente2Id,
                        principalTable: "Taxes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticlesGeneriques_Unites_UniteId",
                        column: x => x.UniteId,
                        principalTable: "Unites",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesGeneriques_ClassificationArticleId",
                table: "ArticlesGeneriques",
                column: "ClassificationArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesGeneriques_CreateurId",
                table: "ArticlesGeneriques",
                column: "CreateurId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesGeneriques_Dimension1Id",
                table: "ArticlesGeneriques",
                column: "Dimension1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesGeneriques_Dimension2Id",
                table: "ArticlesGeneriques",
                column: "Dimension2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesGeneriques_FournisseurPrincipaleId",
                table: "ArticlesGeneriques",
                column: "FournisseurPrincipaleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesGeneriques_ModificateurId",
                table: "ArticlesGeneriques",
                column: "ModificateurId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesGeneriques_TaxeAchat1Id",
                table: "ArticlesGeneriques",
                column: "TaxeAchat1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesGeneriques_TaxeAchat2Id",
                table: "ArticlesGeneriques",
                column: "TaxeAchat2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesGeneriques_TaxeVente1Id",
                table: "ArticlesGeneriques",
                column: "TaxeVente1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesGeneriques_TaxeVente2Id",
                table: "ArticlesGeneriques",
                column: "TaxeVente2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesGeneriques_UniteId",
                table: "ArticlesGeneriques",
                column: "UniteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticlesGeneriques");

            migrationBuilder.DropColumn(
                name: "INCART",
                table: "Parametres");

            migrationBuilder.DropColumn(
                name: "INCARTFAM",
                table: "Parametres");

            migrationBuilder.DropColumn(
                name: "NUMART",
                table: "Parametres");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 3, 14, 51, 50, 974, DateTimeKind.Local).AddTicks(1592),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 4, 15, 8, 18, 456, DateTimeKind.Local).AddTicks(3429));
        }
    }
}
