using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
    public class ArticleGeneriqueConfiguration : IEntityTypeConfiguration<ArticleGenerique>
    {
        public void Configure(EntityTypeBuilder<ArticleGenerique> builder)
        {
           

            builder.Property(s => s.Reference).HasMaxLength(19);
            builder.Property(s => s.Design).HasMaxLength(60);
            builder.Property(s => s.Description).HasMaxLength(90);
            builder.Property(s => s.PrixAchat).HasDefaultValue( 0);
            builder.Property(s => s.Coefficient).HasDefaultValue(0);
            builder.Property(s => s.PrixTTC).HasDefaultValue(0);
            builder.Property(s => s.PrixVente).HasDefaultValue(0);
            builder.Property(s => s.SuiviStock).HasDefaultValue(0);
            builder.Property(s => s.NotImp).HasDefaultValue(false);
            builder.Property(s => s.Remise).HasDefaultValue(0);
            builder.Property(s => s.PrixAchatDernier).HasDefaultValue(0);
            builder.Property(s => s.Sommeil).HasDefaultValue(false);
            builder.Property(s => s.Conditionne).HasDefaultValue(false);
            builder.Property(s => s.QteConditionne).HasDefaultValue(0);
            builder.Property(s => s.TypeArticle).HasDefaultValue(0);
            builder.Property(s => s.Statut).HasDefaultValue(0);
            builder.Property(s => s.Poids).HasDefaultValue(0);
            builder.Property(s => s.EMBALLAGE).HasDefaultValue(0);
            builder.Property(s => s.STOCKMIN).HasDefaultValue(0);
            builder.Property(s => s.FEINTEPROD).HasDefaultValue(0);
            builder.Property(s => s.DELAIAPPRO).HasDefaultValue(0);
            builder.Property(s => s.FEINTAPPRO).HasDefaultValue(0);



            builder.HasOne(d => d.Familles)
                        .WithMany(s => s.ArticleGeneriques)
                        .HasForeignKey(s => s.FamilleId);
            //----------classificationArticle---------
            builder.HasOne(d => d.ClassificationArticles)
                        .WithMany(s => s.ArticleGeneriques)
                        .HasForeignKey(s => s.ClassificationArticleId);
            //--------Unites------------------
            builder.HasOne(d => d.Unites)
                        .WithMany(s => s.ArticleGeneriques)
                        .HasForeignKey(s => s.UniteId);
            //-------dimension dim1---------
            builder.HasOne(d => d.Dimension1)
                        .WithMany(s => s.ArticleGeneriquesDim1)
                        .HasForeignKey(s => s.Dimension1Id);
            //-------dimension dim2---------
            builder.HasOne(d => d.Dimension2)
                        .WithMany(s => s.ArticleGeneriquesDim2)
                        .HasForeignKey(s => s.Dimension2Id);
            //-------utilisateur  createur---------
            builder.HasOne(d => d.Createur)
                         .WithMany(s => s.ArticleGenCrees)
                         .HasForeignKey(s => s.CreateurId);
            //-------utilisateur  modificateur---------
            builder.HasOne(d => d.Modificateur)
                            .WithMany(s => s.ArticleGenModifies)
                            .HasForeignKey(s => s.ModificateurId);
            //-----taxe vente1--------
            builder.HasOne(d => d.TaxeVente1)
                         .WithMany(s => s.TaxeVen1ArtGens)
                         .HasForeignKey(s => s.TaxeVente1Id);
            //-----taxe vente2--------
            builder.HasOne(d => d.TaxeVente2)
                            .WithMany(s => s.TaxeVen2ArtGens)
                            .HasForeignKey(s => s.TaxeVente2Id);

            //------taxe achat1----------------
            builder.HasOne(d => d.TaxeAchat1)
                         .WithMany(s => s.TaxeAch1ArtGens)
                         .HasForeignKey(s => s.TaxeAchat1Id);
            //------taxe achat2----------------
            builder.HasOne(d => d.TaxeAchat2)
                            .WithMany(s => s.TaxeAch2ArtGens)
                            .HasForeignKey(s => s.TaxeAchat2Id);






        }

    }
}
