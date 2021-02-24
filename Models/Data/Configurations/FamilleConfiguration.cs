using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
    public class FamilleConfiguration : IEntityTypeConfiguration<Famille>
    {
        public void Configure(EntityTypeBuilder<Famille> builder)
        {
            builder.Property(s => s.CodeFamille).HasMaxLength(19);
            builder.HasIndex(e => e.CodeFamille)
               .HasName("UnicityCodeFamille").IsUnique();
            builder.Property(s => s.Intitule).HasMaxLength(40);


            builder.HasOne(d => d.Famille0)
                              .WithMany(s => s.Familles)
                              .HasForeignKey(s => s.Famille0Id);

            builder.HasOne(d => d.Unite)
                              .WithMany(s => s.Familles)
                              .HasForeignKey(s => s.UniteId);


            builder.HasOne(d => d.TaxeAchat)
                            .WithMany(s => s.TaxesAchat)
                            .HasForeignKey(s => s.TaxeAchatId);

            builder.HasOne(d => d.TaxeVente)
                            .WithMany(s => s.TaxesVente)
                            .HasForeignKey(s => s.TaxeVenteId);

        }
    }
}
