using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
    public class Famille0Configuration : IEntityTypeConfiguration<Famille0>
    {
        public void Configure(EntityTypeBuilder<Famille0> builder)
        {

            builder.Property(s => s.Code).HasMaxLength(19);
            builder.HasIndex(s => s.Code)
                       .HasName("UnicityCODE").IsUnique();
            builder.Property(s => s.Intitule).HasMaxLength(40);
        }
    }
}
