using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.DataAccess.FluentConfig
{
    public class AnswerConfig : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> modelBuilder)
        {
            modelBuilder.HasKey(e => e.AnswerId);
            modelBuilder.ToTable("Answer", "lsurvey");
            modelBuilder.Property(e => e.CreatedDate).HasColumnType("datetime");
            modelBuilder.Property(e => e.UpdatedBy).HasColumnType("datetime");
            modelBuilder.Property(e => e.UpdatedDate).HasColumnType("datetime");
            modelBuilder.HasOne(d => d.SurveyQuestionOfferedAnswer)
                .WithMany(p => p.Answers)
                .HasForeignKey(d => d.SurveyQuestionOfferedAnswerId)
                .OnDelete(DeleteBehavior.ClientSetNull);
                //.HasConstraintName("FK_Answer_SurveyQuestionOfferedAnswer");
        }
    }
}
