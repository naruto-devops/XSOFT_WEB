﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Data.Configurations
{
    public class ClassifcationArticleConfiguration : IEntityTypeConfiguration<ClassificationArticle>
    {
        public void Configure(EntityTypeBuilder<ClassificationArticle> builder)
        {

            builder.Property(s => s.Code).HasMaxLength(19);
            builder.HasIndex(e => e.Code)
               .HasName("UnicityCode").IsUnique();
            builder.Property(s => s.Libelle).HasMaxLength(50);
        }
    }
}
