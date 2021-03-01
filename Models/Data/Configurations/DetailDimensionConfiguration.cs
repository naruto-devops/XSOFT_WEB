using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
   public class DetailDimensionConfiguration : IEntityTypeConfiguration<DetailDimension>
    {
        public void Configure(EntityTypeBuilder<DetailDimension> builder)
        {

            builder.Property(s => s.Code).HasMaxLength(10);
            builder.HasIndex(s => s.Code)
                       .HasName("UnicityCode").IsUnique();
            builder.Property(s => s.Libelle).HasMaxLength(35);
            builder.Property(s => s.InfoLibre).HasMaxLength(70);

            builder.Property(s => s.Deleted).HasDefaultValue(false);

            //---LinkDimension
            builder.HasOne(d => d.Dimension)
                              .WithMany(s => s.DetailDimensions)
                              .HasForeignKey(s => s.DimensionId);

        }
    }
}
