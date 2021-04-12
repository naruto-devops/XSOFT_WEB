using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategorieTarifs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Categorie = table.Column<string>(maxLength: 12, nullable: true),
                    PrixTTC = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieTarifs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ClassificationArticles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 19, nullable: true),
                    Libelle = table.Column<string>(maxLength: 50, nullable: true),
                    Niveau = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassificationArticles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Devises",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DEVISE = table.Column<string>(maxLength: 12, nullable: true),
                    CODEISO = table.Column<string>(maxLength: 12, nullable: true),
                    CODEBANQUE = table.Column<string>(maxLength: 12, nullable: true),
                    LIBELLE = table.Column<string>(maxLength: 50, nullable: true),
                    SYMBOLE = table.Column<string>(maxLength: 12, nullable: true),
                    DECIMALE = table.Column<int>(maxLength: 1, nullable: false),
                    COURS = table.Column<double>(maxLength: 18, nullable: false),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devises", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: true),
                    Libelle = table.Column<string>(maxLength: 35, nullable: true),
                    Description = table.Column<string>(maxLength: 60, nullable: true),
                    InfoLibre = table.Column<string>(maxLength: 60, nullable: true),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Famille0",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 19, nullable: true),
                    Intitule = table.Column<string>(maxLength: 40, nullable: true),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Famille0", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ModalitePaiements",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Intitule = table.Column<string>(maxLength: 45, nullable: true),
                    Code = table.Column<string>(maxLength: 6, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalitePaiements", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Parametres",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    INCFRS = table.Column<bool>(nullable: false, defaultValue: false),
                    INCCLI = table.Column<bool>(nullable: false, defaultValue: false),
                    NUMFRS = table.Column<string>(maxLength: 17, nullable: true),
                    NUMCLI = table.Column<string>(maxLength: 17, nullable: true),
                    ClientGen = table.Column<string>(maxLength: 13, nullable: true),
                    FournisseurGen = table.Column<string>(maxLength: 13, nullable: true),
                    Devise = table.Column<string>(nullable: true),
                    INCART = table.Column<bool>(nullable: false),
                    INCARTFAM = table.Column<bool>(nullable: false),
                    NUMART = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Taxes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Intitule = table.Column<string>(maxLength: 35, nullable: true),
                    TTaux = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    CompteComptable = table.Column<string>(maxLength: 35, nullable: true),
                    Taux = table.Column<double>(nullable: false),
                    Code = table.Column<string>(maxLength: 5, nullable: true),
                    NonProfitaire = table.Column<bool>(nullable: false),
                    Sens = table.Column<int>(nullable: false),
                    Regroup = table.Column<string>(maxLength: 35, nullable: true),
                    Assujet = table.Column<double>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
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
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unites", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(maxLength: 35, nullable: true),
                    ModePasse = table.Column<string>(maxLength: 500, nullable: true),
                    C_ModePasse = table.Column<string>(maxLength: 500, nullable: true),
                    Description = table.Column<string>(maxLength: 35, nullable: true),
                    Droit = table.Column<int>(nullable: false),
                    Date_connexion = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FamilleTiers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 19, nullable: true),
                    Libelle = table.Column<string>(maxLength: 19, nullable: true),
                    Exonere = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CategorieTarifId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilleTiers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FamilleTiers_CategorieTarifs_CategorieTarifId",
                        column: x => x.CategorieTarifId,
                        principalTable: "CategorieTarifs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetailDimensions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: true),
                    Libelle = table.Column<string>(maxLength: 35, nullable: true),
                    InfoLibre = table.Column<string>(maxLength: 70, nullable: true),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DimensionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailDimensions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DetailDimensions_Dimensions_DimensionId",
                        column: x => x.DimensionId,
                        principalTable: "Dimensions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                    Deleted = table.Column<bool>(nullable: false),
                    Famille0Id = table.Column<int>(nullable: true),
                    UniteId = table.Column<int>(nullable: true),
                    TaxeAchatId = table.Column<int>(nullable: true),
                    TaxeVenteId = table.Column<int>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Famille_Taxes_TaxeAchatId",
                        column: x => x.TaxeAchatId,
                        principalTable: "Taxes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Famille_Taxes_TaxeVenteId",
                        column: x => x.TaxeVenteId,
                        principalTable: "Taxes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Famille_Unites_UniteId",
                        column: x => x.UniteId,
                        principalTable: "Unites",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Collaborateurs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(maxLength: 35, nullable: true),
                    Prenom = table.Column<string>(maxLength: 35, nullable: true),
                    Fonction = table.Column<string>(maxLength: 35, nullable: true),
                    Adresse = table.Column<string>(maxLength: 60, nullable: true),
                    CodePostal = table.Column<string>(maxLength: 9, nullable: true),
                    Ville = table.Column<string>(maxLength: 35, nullable: true),
                    Service = table.Column<string>(maxLength: 35, nullable: true),
                    Telephone = table.Column<string>(maxLength: 21, nullable: true),
                    EMail = table.Column<string>(maxLength: 69, nullable: true),
                    Matricule = table.Column<string>(maxLength: 11, nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false),
                    UtilisateurId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collaborateurs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Collaborateurs_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EProtections",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Droit = table.Column<int>(nullable: false),
                    UtilisateurID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EProtections", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EProtections_Utilisateurs_UtilisateurID",
                        column: x => x.UtilisateurID,
                        principalTable: "Utilisateurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tiers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<string>(maxLength: 17, nullable: true),
                    Intitule = table.Column<string>(maxLength: 35, nullable: true),
                    Type = table.Column<int>(nullable: false),
                    NumeroPrincipale = table.Column<string>(maxLength: 13, nullable: true),
                    ContactPrincipale = table.Column<string>(maxLength: 35, nullable: true),
                    Complement = table.Column<string>(maxLength: 35, nullable: true),
                    CodePostal = table.Column<string>(maxLength: 9, nullable: true),
                    Ville = table.Column<string>(maxLength: 35, nullable: true),
                    CodeRegion = table.Column<string>(maxLength: 25, nullable: true),
                    Pays = table.Column<string>(maxLength: 35, nullable: true),
                    Raccourcis = table.Column<string>(maxLength: 7, nullable: true),
                    NumeroBanqueTier = table.Column<int>(nullable: false),
                    Ape = table.Column<string>(maxLength: 7, nullable: true),
                    MatriculeFiscale = table.Column<string>(maxLength: 25, nullable: true),
                    Siret = table.Column<string>(maxLength: 15, nullable: true),
                    Encours = table.Column<double>(maxLength: 24, nullable: false),
                    NumeroPayeur = table.Column<string>(maxLength: 17, nullable: true),
                    Deleted = table.Column<bool>(nullable: false, defaultValue: false),
                    ExonereTVA = table.Column<bool>(nullable: false),
                    DateCreation = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2021, 4, 9, 10, 17, 58, 578, DateTimeKind.Local).AddTicks(6676)),
                    Sommeil = table.Column<bool>(nullable: false),
                    Depot = table.Column<int>(nullable: false),
                    Telephone = table.Column<string>(maxLength: 21, nullable: true),
                    Telecopie = table.Column<string>(maxLength: 21, nullable: true),
                    EMail = table.Column<string>(maxLength: 69, nullable: true),
                    SiteWeb = table.Column<string>(maxLength: 69, nullable: true),
                    Timbre = table.Column<bool>(nullable: false),
                    TauxRemise = table.Column<double>(maxLength: 18, nullable: false, defaultValue: 0.0),
                    CategorieTVA = table.Column<string>(maxLength: 7, nullable: true),
                    Categorie = table.Column<string>(maxLength: 7, nullable: true),
                    Etranger = table.Column<bool>(nullable: false),
                    CoursDevise = table.Column<double>(maxLength: 18, nullable: false),
                    ADRESSELivraison = table.Column<string>(maxLength: 70, nullable: true),
                    CodePostalLivraison = table.Column<string>(maxLength: 10, nullable: true),
                    VilleLivraison = table.Column<string>(maxLength: 35, nullable: true),
                    PaysLivraison = table.Column<string>(maxLength: 35, nullable: true),
                    Qualite = table.Column<string>(maxLength: 35, nullable: true),
                    Adresse = table.Column<string>(maxLength: 60, nullable: true),
                    Commentaire = table.Column<string>(maxLength: 100, nullable: true),
                    Classement = table.Column<string>(maxLength: 35, nullable: true),
                    Jointe1 = table.Column<string>(maxLength: 150, nullable: true),
                    Jointe2 = table.Column<string>(maxLength: 150, nullable: true),
                    Incoterm = table.Column<string>(nullable: true),
                    CompteAuxiliaire = table.Column<string>(maxLength: 20, nullable: true),
                    ICE = table.Column<string>(maxLength: 20, nullable: true),
                    CREATEURId = table.Column<int>(nullable: true),
                    MODIFICATEURId = table.Column<int>(nullable: true),
                    CategorieTarifId = table.Column<int>(nullable: true),
                    CollaborateurId = table.Column<int>(nullable: true),
                    DeviseId = table.Column<int>(nullable: true),
                    FamilleTierId = table.Column<int>(nullable: true),
                    ModalitePaiementId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tiers_Utilisateurs_CREATEURId",
                        column: x => x.CREATEURId,
                        principalTable: "Utilisateurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tiers_CategorieTarifs_CategorieTarifId",
                        column: x => x.CategorieTarifId,
                        principalTable: "CategorieTarifs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tiers_Collaborateurs_CollaborateurId",
                        column: x => x.CollaborateurId,
                        principalTable: "Collaborateurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tiers_Devises_DeviseId",
                        column: x => x.DeviseId,
                        principalTable: "Devises",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tiers_FamilleTiers_FamilleTierId",
                        column: x => x.FamilleTierId,
                        principalTable: "FamilleTiers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tiers_Utilisateurs_MODIFICATEURId",
                        column: x => x.MODIFICATEURId,
                        principalTable: "Utilisateurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tiers_ModalitePaiements_ModalitePaiementId",
                        column: x => x.ModalitePaiementId,
                        principalTable: "ModalitePaiements",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    FamilleId = table.Column<int>(nullable: true),
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
                        name: "FK_ArticlesGeneriques_Famille_FamilleId",
                        column: x => x.FamilleId,
                        principalTable: "Famille",
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

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomPrenom = table.Column<string>(maxLength: 35, nullable: true),
                    Fonction = table.Column<string>(maxLength: 35, nullable: true),
                    Adresse = table.Column<string>(maxLength: 35, nullable: true),
                    CodePostal = table.Column<string>(maxLength: 10, nullable: true),
                    Ville = table.Column<string>(maxLength: 35, nullable: true),
                    Pays = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(maxLength: 35, nullable: true),
                    Portable = table.Column<string>(maxLength: 35, nullable: true),
                    Fax = table.Column<string>(maxLength: 35, nullable: true),
                    Email = table.Column<string>(maxLength: 35, nullable: true),
                    Type = table.Column<int>(maxLength: 1, nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    TiersId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contacts_Tiers_TiersId",
                        column: x => x.TiersId,
                        principalTable: "Tiers",
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
                name: "IX_ArticlesGeneriques_FamilleId",
                table: "ArticlesGeneriques",
                column: "FamilleId");

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

            migrationBuilder.CreateIndex(
                name: "UnicityCategorie",
                table: "CategorieTarifs",
                column: "Categorie",
                unique: true,
                filter: "[Categorie] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UnicityCode",
                table: "ClassificationArticles",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborateurs_UtilisateurId",
                table: "Collaborateurs",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_TiersId",
                table: "Contacts",
                column: "TiersId");

            migrationBuilder.CreateIndex(
                name: "UnicityCode",
                table: "DetailDimensions",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DetailDimensions_DimensionId",
                table: "DetailDimensions",
                column: "DimensionId");

            migrationBuilder.CreateIndex(
                name: "UnicityDEVISE",
                table: "Devises",
                column: "DEVISE",
                unique: true,
                filter: "[DEVISE] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UnicityCode",
                table: "Dimensions",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EProtections_UtilisateurID",
                table: "EProtections",
                column: "UtilisateurID");

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
                name: "IX_Famille_TaxeAchatId",
                table: "Famille",
                column: "TaxeAchatId");

            migrationBuilder.CreateIndex(
                name: "IX_Famille_TaxeVenteId",
                table: "Famille",
                column: "TaxeVenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Famille_UniteId",
                table: "Famille",
                column: "UniteId");

            migrationBuilder.CreateIndex(
                name: "UnicityCODE",
                table: "Famille0",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FamilleTiers_CategorieTarifId",
                table: "FamilleTiers",
                column: "CategorieTarifId");

            migrationBuilder.CreateIndex(
                name: "UnicityCode",
                table: "FamilleTiers",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UnicityCode",
                table: "ModalitePaiements",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UnicityCodeTaxe",
                table: "Taxes",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tiers_CREATEURId",
                table: "Tiers",
                column: "CREATEURId");

            migrationBuilder.CreateIndex(
                name: "IX_Tiers_CategorieTarifId",
                table: "Tiers",
                column: "CategorieTarifId");

            migrationBuilder.CreateIndex(
                name: "IX_Tiers_CollaborateurId",
                table: "Tiers",
                column: "CollaborateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Tiers_DeviseId",
                table: "Tiers",
                column: "DeviseId");

            migrationBuilder.CreateIndex(
                name: "IX_Tiers_FamilleTierId",
                table: "Tiers",
                column: "FamilleTierId");

            migrationBuilder.CreateIndex(
                name: "IX_Tiers_MODIFICATEURId",
                table: "Tiers",
                column: "MODIFICATEURId");

            migrationBuilder.CreateIndex(
                name: "IX_Tiers_ModalitePaiementId",
                table: "Tiers",
                column: "ModalitePaiementId");

            migrationBuilder.CreateIndex(
                name: "UnicityLibelle",
                table: "Unites",
                column: "Libelle",
                unique: true,
                filter: "[Libelle] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UnicityNomUtilisateur",
                table: "Utilisateurs",
                column: "User",
                unique: true,
                filter: "[User] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticlesGeneriques");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "DetailDimensions");

            migrationBuilder.DropTable(
                name: "EProtections");

            migrationBuilder.DropTable(
                name: "Parametres");

            migrationBuilder.DropTable(
                name: "ClassificationArticles");

            migrationBuilder.DropTable(
                name: "Famille");

            migrationBuilder.DropTable(
                name: "Tiers");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "Famille0");

            migrationBuilder.DropTable(
                name: "Taxes");

            migrationBuilder.DropTable(
                name: "Unites");

            migrationBuilder.DropTable(
                name: "Collaborateurs");

            migrationBuilder.DropTable(
                name: "Devises");

            migrationBuilder.DropTable(
                name: "FamilleTiers");

            migrationBuilder.DropTable(
                name: "ModalitePaiements");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "CategorieTarifs");
        }
    }
}
