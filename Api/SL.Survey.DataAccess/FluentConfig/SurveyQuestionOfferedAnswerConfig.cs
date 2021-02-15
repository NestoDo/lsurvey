using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.DataAccess.FluentConfig
{
    public class SurveyQuestionOfferedAnswerConfig : IEntityTypeConfiguration<SurveyQuestionOfferedAnswer>
    {
        public void Configure(EntityTypeBuilder<SurveyQuestionOfferedAnswer> modelBuilder)
        {
            modelBuilder.HasKey(e => e.IdSurveyQuestionOfferedAnswer);
            modelBuilder.ToTable("SurveyQuestionOfferedAnswer", "lsurvey");
            modelBuilder.Property(e => e.CreatedDate).HasColumnType("datetime");
            modelBuilder.Property(e => e.UpdatedBy).HasColumnType("datetime");
            modelBuilder.Property(e => e.UpdatedDate).HasColumnType("datetime");
            modelBuilder.HasOne(d => d.IdOfferedAnswerNavigation)
                .WithMany(p => p.SurveyQuestionOfferedAnswers)
                .HasForeignKey(d => d.IdOfferedAnswer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurveyQuestionOfferedAnswer_OfferedAnswer1");
            modelBuilder.HasOne(d => d.IdSurveyQuestionNavigation)
                .WithMany(p => p.SurveyQuestionOfferedAnswers)
                .HasForeignKey(d => d.IdSurveyQuestion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurveyQuestionOfferedAnswer_SurveyQuestion1");
        }
    }
}
