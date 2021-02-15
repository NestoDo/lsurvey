using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.DataAccess.FluentConfig
{
    public class SurveyTypeConfig : IEntityTypeConfiguration<SurveyType>
    {
        public void Configure(EntityTypeBuilder<SurveyType> modelBuilder)
        {
            modelBuilder.HasKey(e => e.IdSurveyType);
            modelBuilder.ToTable("SurveyType", "lsurvey");
            modelBuilder.Property(e => e.CreatedDate).HasColumnType("datetime");
            modelBuilder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            modelBuilder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            modelBuilder.Property(e => e.UpdatedBy).HasColumnType("datetime");
            modelBuilder.Property(e => e.UpdatedDate).HasColumnType("datetime");
        }
    }
}
