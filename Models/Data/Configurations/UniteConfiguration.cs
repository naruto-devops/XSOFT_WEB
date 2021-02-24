using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
   public  class UniteConfiguration : IEntityTypeConfiguration<Unite>
    {
        public void Configure(EntityTypeBuilder<Unite> builder)
         {

        builder.Property(s => s.Libelle).HasMaxLength(30);
        builder.HasIndex(s => s.Libelle)
                   .HasName("UnicityLibelle").IsUnique();
       
         }
    
    }
}
