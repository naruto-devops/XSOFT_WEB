﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.Data;

namespace Models.Migrations
{
    [DbContext(typeof(XSoftContext))]
    partial class XSoftContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.ModalitePaiement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(6);

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Intitule")
                        .HasMaxLength(45);

                    b.HasKey("ID");

                    b.HasIndex("Code")
                        .IsUnique()
                        .HasName("UnicityCode")
                        .HasFilter("[Code] IS NOT NULL");

                    b.ToTable("ModalitePaiements");
                });

            modelBuilder.Entity("Models.Models.CategorieTarif", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categorie")
                        .HasMaxLength(12);

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool>("PrixTTC");

                    b.HasKey("ID");

                    b.HasIndex("Categorie")
                        .IsUnique()
                        .HasName("UnicityCategorie")
                        .HasFilter("[Categorie] IS NOT NULL");

                    b.ToTable("CategorieTarifs");
                });

            modelBuilder.Entity("Models.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ADRESSELivraison")
                        .HasMaxLength(70);

                    b.Property<string>("Adresse")
                        .HasMaxLength(60);

                    b.Property<string>("Ape")
                        .HasMaxLength(7);

                    b.Property<int?>("CREATEURId");

                    b.Property<string>("Categorie")
                        .HasMaxLength(7);

                    b.Property<string>("CategorieTVA")
                        .HasMaxLength(7);

                    b.Property<int?>("CategorieTarifId");

                    b.Property<string>("Classement")
                        .HasMaxLength(35);

                    b.Property<string>("CodePostal")
                        .HasMaxLength(9);

                    b.Property<string>("CodePostalLivraison")
                        .HasMaxLength(10);

                    b.Property<string>("CodeRegion")
                        .HasMaxLength(25);

                    b.Property<int?>("CollaborateurId");

                    b.Property<string>("Commentaire")
                        .HasMaxLength(100);

                    b.Property<string>("Complement")
                        .HasMaxLength(35);

                    b.Property<string>("CompteAuxiliaire")
                        .HasMaxLength(20);

                    b.Property<string>("ContactPrincipale")
                        .HasMaxLength(35);

                    b.Property<double>("CoursDevise")
                        .HasMaxLength(18);

                    b.Property<DateTime>("DateCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2021, 2, 16, 12, 42, 34, 1, DateTimeKind.Local).AddTicks(7850));

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("Depot");

                    b.Property<int?>("DeviseId");

                    b.Property<string>("EMail")
                        .HasMaxLength(69);

                    b.Property<double>("Encours")
                        .HasMaxLength(24);

                    b.Property<bool>("Etranger");

                    b.Property<bool>("ExonereTVA");

                    b.Property<int?>("FamilleTierId");

                    b.Property<string>("ICE")
                        .HasMaxLength(20);

                    b.Property<string>("Incoterm");

                    b.Property<string>("Intitule")
                        .HasMaxLength(35);

                    b.Property<string>("Jointe1")
                        .HasMaxLength(150);

                    b.Property<string>("Jointe2")
                        .HasMaxLength(150);

                    b.Property<int?>("MODIFICATEURId");

                    b.Property<string>("MatriculeFiscale")
                        .HasMaxLength(25);

                    b.Property<int?>("ModalitePaiementId");

                    b.Property<string>("Numero")
                        .HasMaxLength(17);

                    b.Property<int>("NumeroBanqueTier");

                    b.Property<string>("NumeroPayeur")
                        .HasMaxLength(17);

                    b.Property<string>("NumeroPrincipale")
                        .HasMaxLength(13);

                    b.Property<string>("Pays")
                        .HasMaxLength(35);

                    b.Property<string>("PaysLivraison")
                        .HasMaxLength(35);

                    b.Property<string>("Qualite")
                        .HasMaxLength(35);

                    b.Property<string>("Raccourcis")
                        .HasMaxLength(7);

                    b.Property<string>("Siret")
                        .HasMaxLength(15);

                    b.Property<string>("SiteWeb")
                        .HasMaxLength(69);

                    b.Property<bool>("Sommeil");

                    b.Property<double>("TauxRemise")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(18)
                        .HasDefaultValue(0.0);

                    b.Property<string>("Telecopie")
                        .HasMaxLength(21);

                    b.Property<string>("Telephone")
                        .HasMaxLength(21);

                    b.Property<bool>("Timbre");

                    b.Property<int>("Type")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Ville")
                        .HasMaxLength(35);

                    b.Property<string>("VilleLivraison")
                        .HasMaxLength(35);

                    b.HasKey("ID");

                    b.HasIndex("CREATEURId");

                    b.HasIndex("CategorieTarifId");

                    b.HasIndex("CollaborateurId");

                    b.HasIndex("DeviseId");

                    b.HasIndex("FamilleTierId");

                    b.HasIndex("MODIFICATEURId");

                    b.HasIndex("ModalitePaiementId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Models.Models.Collaborateur", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse")
                        .HasMaxLength(60);

                    b.Property<string>("CodePostal")
                        .HasMaxLength(9);

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("EMail")
                        .HasMaxLength(69);

                    b.Property<string>("Fonction")
                        .HasMaxLength(35);

                    b.Property<string>("Matricule")
                        .HasMaxLength(11);

                    b.Property<string>("Nom")
                        .HasMaxLength(35);

                    b.Property<string>("Prenom")
                        .HasMaxLength(35);

                    b.Property<string>("Service")
                        .HasMaxLength(35);

                    b.Property<string>("Telephone")
                        .HasMaxLength(21);

                    b.Property<int>("Type");

                    b.Property<int?>("UtilisateurId");

                    b.Property<string>("Ville")
                        .HasMaxLength(35);

                    b.HasKey("ID");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("Collaborateurs");
                });

            modelBuilder.Entity("Models.Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse")
                        .HasMaxLength(35);

                    b.Property<int?>("ClientID");

                    b.Property<int?>("ClienttId");

                    b.Property<string>("CodePostal")
                        .HasMaxLength(10);

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Email")
                        .HasMaxLength(35);

                    b.Property<string>("Fax")
                        .HasMaxLength(35);

                    b.Property<string>("Fonction")
                        .HasMaxLength(35);

                    b.Property<string>("NomPrenom")
                        .HasMaxLength(35);

                    b.Property<string>("Pays");

                    b.Property<string>("Portable")
                        .HasMaxLength(35);

                    b.Property<string>("Telephone")
                        .HasMaxLength(35);

                    b.Property<int>("Type")
                        .HasMaxLength(1);

                    b.Property<string>("Ville")
                        .HasMaxLength(35);

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Models.Models.Devise", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CODEBANQUE")
                        .HasMaxLength(12);

                    b.Property<string>("CODEISO")
                        .HasMaxLength(12);

                    b.Property<double>("COURS")
                        .HasMaxLength(18);

                    b.Property<int>("DECIMALE")
                        .HasMaxLength(1);

                    b.Property<string>("DEVISE")
                        .HasMaxLength(12);

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("LIBELLE")
                        .HasMaxLength(50);

                    b.Property<string>("SYMBOLE")
                        .HasMaxLength(12);

                    b.HasKey("ID");

                    b.HasIndex("DEVISE")
                        .IsUnique()
                        .HasName("UnicityDEVISE")
                        .HasFilter("[DEVISE] IS NOT NULL");

                    b.ToTable("Devises");
                });

            modelBuilder.Entity("Models.Models.EProtection", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Droit");

                    b.Property<int?>("UtilisateurID");

                    b.HasKey("ID");

                    b.HasIndex("UtilisateurID");

                    b.ToTable("EProtections");
                });

            modelBuilder.Entity("Models.Models.FamilleTier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategorieTarifId");

                    b.Property<string>("Code")
                        .HasMaxLength(19);

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool>("Exonere");

                    b.Property<string>("Libelle")
                        .HasMaxLength(19);

                    b.HasKey("ID");

                    b.HasIndex("CategorieTarifId");

                    b.HasIndex("Code")
                        .IsUnique()
                        .HasName("UnicityCode")
                        .HasFilter("[Code] IS NOT NULL");

                    b.ToTable("FamilleTiers");
                });

            modelBuilder.Entity("Models.Models.Parametres", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientGen")
                        .HasMaxLength(17);

                    b.Property<string>("Devise");

                    b.Property<bool>("INCCLI")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool>("INCFRS")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("NUMCLI")
                        .HasMaxLength(17);

                    b.Property<string>("NUMFRS")
                        .HasMaxLength(17);

                    b.HasKey("ID");

                    b.ToTable("Parametres");
                });

            modelBuilder.Entity("Models.Models.Utilisateur", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("C_ModePasse")
                        .HasMaxLength(12);

                    b.Property<DateTime>("Date_connexion");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Description")
                        .HasMaxLength(50);

                    b.Property<int>("Droit");

                    b.Property<string>("ModePasse")
                        .HasMaxLength(12);

                    b.Property<string>("User")
                        .HasMaxLength(12);

                    b.HasKey("ID");

                    b.HasIndex("User")
                        .IsUnique()
                        .HasName("UnicityNomUtilisateur")
                        .HasFilter("[User] IS NOT NULL");

                    b.ToTable("Utilisateurs");
                });

            modelBuilder.Entity("Models.Models.Client", b =>
                {
                    b.HasOne("Models.Models.Utilisateur", "CREATEUR")
                        .WithMany("ClientCrees")
                        .HasForeignKey("CREATEURId");

                    b.HasOne("Models.Models.CategorieTarif", "CategorieTarif")
                        .WithMany("Clients")
                        .HasForeignKey("CategorieTarifId");

                    b.HasOne("Models.Models.Collaborateur", "Collaborateur")
                        .WithMany("Clients")
                        .HasForeignKey("CollaborateurId");

                    b.HasOne("Models.Models.Devise", "Devise")
                        .WithMany("Clients")
                        .HasForeignKey("DeviseId");

                    b.HasOne("Models.Models.FamilleTier", "FamilleTier")
                        .WithMany("Clients")
                        .HasForeignKey("FamilleTierId");

                    b.HasOne("Models.Models.Utilisateur", "MODIFICATEUR")
                        .WithMany("ClientModifies")
                        .HasForeignKey("MODIFICATEURId");

                    b.HasOne("Models.ModalitePaiement", "ModalitePaiement")
                        .WithMany("Clients")
                        .HasForeignKey("ModalitePaiementId");
                });

            modelBuilder.Entity("Models.Models.Collaborateur", b =>
                {
                    b.HasOne("Models.Models.Utilisateur", "Utilisateur")
                        .WithMany("Collaborateurs")
                        .HasForeignKey("UtilisateurId");
                });

            modelBuilder.Entity("Models.Models.Contact", b =>
                {
                    b.HasOne("Models.Models.Client", "Client")
                        .WithMany("Contacts")
                        .HasForeignKey("ClientID");
                });

            modelBuilder.Entity("Models.Models.EProtection", b =>
                {
                    b.HasOne("Models.Models.Utilisateur", "Utilisateur")
                        .WithMany("EProtections")
                        .HasForeignKey("UtilisateurID");
                });

            modelBuilder.Entity("Models.Models.FamilleTier", b =>
                {
                    b.HasOne("Models.Models.CategorieTarif", "CategorieTarif")
                        .WithMany("FamilleTiers")
                        .HasForeignKey("CategorieTarifId");
                });
#pragma warning restore 612, 618
        }
    }
}
