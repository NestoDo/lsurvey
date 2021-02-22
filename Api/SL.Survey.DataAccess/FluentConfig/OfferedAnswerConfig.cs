using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.DataAccess.FluentConfig
{
    public class OfferedAnswerConfig : IEntityTypeConfiguration<OfferedAnswer>
    {
        public void Configure(EntityTypeBuilder<OfferedAnswer> modelBuilder)
        {
            modelBuilder.HasKey(e => e.OfferedAnswerId);
            modelBuilder.ToTable("OfferedAnswer", "lsurvey");
            modelBuilder.Property(e => e.Answer)
                    .IsRequired()
                    .IsUnicode(false);
            modelBuilder.Property(e => e.CreatedDate).HasColumnType("datetime");
            modelBuilder.Property(e => e.UpdatedBy).HasColumnType("datetime");
            modelBuilder.Property(e => e.UpdatedDate).HasColumnType("datetime");
        }
    }
}
