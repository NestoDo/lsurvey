using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.DataAccess.FluentConfig
{
    public class QuestionConfig : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> modelBuilder)
        {
                modelBuilder.HasKey(e => e.QuestionId);
                modelBuilder.ToTable("Question", "lsurvey");
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
