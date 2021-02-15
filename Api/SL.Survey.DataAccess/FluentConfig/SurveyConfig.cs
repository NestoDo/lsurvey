using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.DataAccess.FluentConfig
{
    public class SurveyConfig : IEntityTypeConfiguration<SL.Survey.Entities.Model.Survey>
    {
        public void Configure(EntityTypeBuilder<SL.Survey.Entities.Model.Survey> modelBuilder)
        {
            modelBuilder.HasKey(e => e.IdSurvey);
            modelBuilder.ToTable("Survey", "lsurvey");
            modelBuilder.Property(e => e.CreatedDate).HasColumnType("datetime");
            modelBuilder.Property(e => e.Instructions)
                .IsRequired()
                .IsUnicode(false);
            modelBuilder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            modelBuilder.Property(e => e.OtherInfo)
                .IsRequired()
                .IsUnicode(false);
            modelBuilder.Property(e => e.UpdatedBy).HasColumnType("datetime");
            modelBuilder.Property(e => e.UpdatedDate).HasColumnType("datetime");
            modelBuilder.HasOne(d => d.IdSurveyTypeNavigation)
                .WithMany(p => p.Surveys)
                .HasForeignKey(d => d.IdSurveyType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Survey_SurveyType");
        }
    }
}
