using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
    public class TaxeConfiguration : IEntityTypeConfiguration<Taxe>
    {
        public void Configure(EntityTypeBuilder<Taxe> builder)
    {
        builder.Property(s => s.Intitule).HasMaxLength(35);
        builder.HasIndex(e => e.Code)
           .HasName("UnicityCodeTaxe").IsUnique();

        builder.Property(s => s.Code).HasMaxLength(5);
            builder.Property(s => s.Regroup).HasMaxLength(35);
            builder.Property(s => s.CompteComptable).HasMaxLength(35);
            builder.Property(s => s.CompteComptable).HasDefaultValue(null);




        }
    }
}
