using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.DataAccess.FluentConfig
{
    public class SurveyQuestionConfig : IEntityTypeConfiguration<SurveyQuestion>
    {
        public void Configure(EntityTypeBuilder<SurveyQuestion> modelBuilder)
        {
            modelBuilder.HasKey(e => e.IdSurveyQuestion);
            modelBuilder.ToTable("SurveyQuestion", "lsurvey");
            modelBuilder.Property(e => e.CreatedDate).HasColumnType("datetime");
            modelBuilder.Property(e => e.UpdatedBy).HasColumnType("datetime");
            modelBuilder.Property(e => e.UpdatedDate).HasColumnType("datetime");
            modelBuilder.HasOne(d => d.IdQuestionNavigation)
                .WithMany(p => p.SurveyQuestions)
                .HasForeignKey(d => d.IdQuestion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurveyQuestion_Question");
            modelBuilder.HasOne(d => d.IdQuestionTypeNavigation)
                .WithMany(p => p.SurveyQuestions)
                .HasForeignKey(d => d.IdQuestionType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurveyQuestion_QuestionType");
            modelBuilder.HasOne(d => d.IdSurveyNavigation)
                .WithMany(p => p.SurveyQuestions)
                .HasForeignKey(d => d.IdSurvey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SurveyQuestion_Survey");            
        }
    }
}
