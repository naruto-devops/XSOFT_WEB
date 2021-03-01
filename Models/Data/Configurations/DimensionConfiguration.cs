using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
   public  class DimensionConfiguration : IEntityTypeConfiguration<Dimension>
    {
        public void Configure(EntityTypeBuilder<Dimension> builder)
        {

            builder.Property(s => s.Code).HasMaxLength(10);
            builder.HasIndex(e => e.Code)
               .HasName("UnicityCode").IsUnique();

            builder.Property(s => s.Libelle).HasMaxLength(35);
            builder.Property(s => s.Description).HasMaxLength(60);
            builder.Property(s => s.InfoLibre).HasMaxLength(60);
            builder.Property(s => s.Deleted).HasDefaultValue(false);
        }

    }
}
