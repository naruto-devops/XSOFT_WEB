using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.Data.Configurations;
using Models.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Models.Data
{
    public class XSoftContext : DbContext
    {
        public XSoftContext()
        {
        }

        public XSoftContext(DbContextOptions<XSoftContext> options) : base()
        {
        }
        public virtual DbSet<Tiers> Tiers { get; set; }
        public virtual DbSet<CategorieTarif> CategorieTarifs { get; set; }
        public virtual DbSet<Devise> Devises { get; set; }
        public virtual DbSet<Collaborateur> Collaborateurs { get; set; }
        public virtual DbSet<FamilleTier> FamilleTiers { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ModalitePaiement> ModalitePaiements { get; set; }
        public virtual DbSet<Parametres> Parametres { get; set; }
        public virtual DbSet<EProtection> EProtections { get; set; }
        public virtual DbSet<Famille> Famille { get; set; }
        public virtual DbSet<Famille0> Famille0 { get; set; }
        public virtual DbSet<Unite> Unites { get; set; }
        public virtual DbSet<Taxe> Taxes { get; set; }
        public virtual DbSet<Dimension> Dimensions { get; set; }
        public virtual DbSet<DetailDimension> DetailDimensions { get; set; }
        public virtual DbSet<ClassificationArticle> ClassificationArticles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json")
                  .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TiersConfiguration());
            modelBuilder.ApplyConfiguration(new DeviseConfiguration());
            modelBuilder.ApplyConfiguration(new CategorieTarifConfiguration());
            modelBuilder.ApplyConfiguration(new FamilleTierConfiguration());
            modelBuilder.ApplyConfiguration(new UtilisateurConfiguration());
            modelBuilder.ApplyConfiguration(new CollaborateurConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new ModalitePaiementConfiguration());
            modelBuilder.ApplyConfiguration(new ParametresConfiguration());
            modelBuilder.ApplyConfiguration(new FamilleConfiguration());
            modelBuilder.ApplyConfiguration(new Famille0Configuration());
            modelBuilder.ApplyConfiguration(new UniteConfiguration());
            modelBuilder.ApplyConfiguration(new TaxeConfiguration());
            modelBuilder.ApplyConfiguration(new DetailDimensionConfiguration());
            modelBuilder.ApplyConfiguration(new DimensionConfiguration());
            modelBuilder.ApplyConfiguration(new ClassifcationArticleConfiguration());


        }
    }
}
