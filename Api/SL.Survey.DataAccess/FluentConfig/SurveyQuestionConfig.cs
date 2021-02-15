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
            modelBuilder.HasKey(e => e.SurveyQuestionId);
            modelBuilder.ToTable("SurveyQuestion", "lsurvey");
            modelBuilder.Property(e => e.CreatedDate).HasColumnType("datetime");
            modelBuilder.Property(e => e.UpdatedBy).HasColumnType("datetime");
            modelBuilder.Property(e => e.UpdatedDate).HasColumnType("datetime");
            modelBuilder.HasOne(d => d.QuestionIdNavigation)
                .WithMany(p => p.SurveyQuestions)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            //.HasConstraintName("FK_SurveyQuestion_Question");
            modelBuilder.HasOne(d => d.QuestionTypeIdNavigation)
                .WithMany(p => p.SurveyQuestions)
                .HasForeignKey(d => d.QuestionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            //.HasConstraintName("FK_SurveyQuestion_QuestionType");
            modelBuilder.HasOne(d => d.SurveyIdNavigation)
                .WithMany(p => p.SurveyQuestions)
                .HasForeignKey(d => d.SurveyId)
                .OnDelete(DeleteBehavior.ClientSetNull);
                //.HasConstraintName("FK_SurveyQuestion_Survey");            
        }
    }
}
