﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SL.Survey.DataAccess.Data;

namespace SL.Survey.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SL.Survey.Entities.Model.Answer", b =>
                {
                    b.Property<int>("IdAnswer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int>("IdSurveyQuestionOfferedAnswer")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedBy")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("IdAnswer");

                    b.HasIndex("IdSurveyQuestionOfferedAnswer");

                    b.ToTable("Answer", "lsurvey");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.OfferedAnswer", b =>
                {
                    b.Property<int>("IdOfferedAnswer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("UpdatedBy")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("IdOfferedAnswer");

                    b.ToTable("OfferedAnswer", "lsurvey");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.Question", b =>
                {
                    b.Property<int>("IdQuestion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("UpdatedBy")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("IdQuestion");

                    b.ToTable("Question", "lsurvey");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.QuestionType", b =>
                {
                    b.Property<int>("IdQuestionType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("UpdatedBy")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("IdQuestionType");

                    b.ToTable("QuestionType", "lsurvey");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.Survey", b =>
                {
                    b.Property<int>("IdSurvey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int>("IdSurveyType")
                        .HasColumnType("int");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("OtherInfo")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime>("UpdatedBy")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("IdSurvey");

                    b.HasIndex("IdSurveyType");

                    b.ToTable("Survey", "lsurvey");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.SurveyQuestion", b =>
                {
                    b.Property<int>("IdSurveyQuestion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int>("IdQuestion")
                        .HasColumnType("int");

                    b.Property<int>("IdQuestionType")
                        .HasColumnType("int");

                    b.Property<int>("IdSurvey")
                        .HasColumnType("int");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedBy")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("IdSurveyQuestion");

                    b.HasIndex("IdQuestion");

                    b.HasIndex("IdQuestionType");

                    b.HasIndex("IdSurvey");

                    b.ToTable("SurveyQuestion", "lsurvey");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.SurveyQuestionOfferedAnswer", b =>
                {
                    b.Property<int>("IdSurveyQuestionOfferedAnswer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<int>("IdOfferedAnswer")
                        .HasColumnType("int");

                    b.Property<int>("IdSurveyQuestion")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedBy")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("IdSurveyQuestionOfferedAnswer");

                    b.HasIndex("IdOfferedAnswer");

                    b.HasIndex("IdSurveyQuestion");

                    b.ToTable("SurveyQuestionOfferedAnswer", "lsurvey");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.SurveyType", b =>
                {
                    b.Property<int>("IdSurveyType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("UpdatedBy")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("IdSurveyType");

                    b.ToTable("SurveyType", "lsurvey");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.Answer", b =>
                {
                    b.HasOne("SL.Survey.Entities.Model.SurveyQuestionOfferedAnswer", "IdSurveyQuestionOfferedAnswerNavigation")
                        .WithMany("Answers")
                        .HasForeignKey("IdSurveyQuestionOfferedAnswer")
                        .HasConstraintName("FK_Answer_SurveyQuestionOfferedAnswer")
                        .IsRequired();

                    b.Navigation("IdSurveyQuestionOfferedAnswerNavigation");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.Survey", b =>
                {
                    b.HasOne("SL.Survey.Entities.Model.SurveyType", "IdSurveyTypeNavigation")
                        .WithMany("Surveys")
                        .HasForeignKey("IdSurveyType")
                        .HasConstraintName("FK_Survey_SurveyType")
                        .IsRequired();

                    b.Navigation("IdSurveyTypeNavigation");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.SurveyQuestion", b =>
                {
                    b.HasOne("SL.Survey.Entities.Model.Question", "IdQuestionNavigation")
                        .WithMany("SurveyQuestions")
                        .HasForeignKey("IdQuestion")
                        .HasConstraintName("FK_SurveyQuestion_Question")
                        .IsRequired();

                    b.HasOne("SL.Survey.Entities.Model.QuestionType", "IdQuestionTypeNavigation")
                        .WithMany("SurveyQuestions")
                        .HasForeignKey("IdQuestionType")
                        .HasConstraintName("FK_SurveyQuestion_QuestionType")
                        .IsRequired();

                    b.HasOne("SL.Survey.Entities.Model.Survey", "IdSurveyNavigation")
                        .WithMany("SurveyQuestions")
                        .HasForeignKey("IdSurvey")
                        .HasConstraintName("FK_SurveyQuestion_Survey")
                        .IsRequired();

                    b.Navigation("IdQuestionNavigation");

                    b.Navigation("IdQuestionTypeNavigation");

                    b.Navigation("IdSurveyNavigation");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.SurveyQuestionOfferedAnswer", b =>
                {
                    b.HasOne("SL.Survey.Entities.Model.OfferedAnswer", "IdOfferedAnswerNavigation")
                        .WithMany("SurveyQuestionOfferedAnswers")
                        .HasForeignKey("IdOfferedAnswer")
                        .HasConstraintName("FK_SurveyQuestionOfferedAnswer_OfferedAnswer1")
                        .IsRequired();

                    b.HasOne("SL.Survey.Entities.Model.SurveyQuestion", "IdSurveyQuestionNavigation")
                        .WithMany("SurveyQuestionOfferedAnswers")
                        .HasForeignKey("IdSurveyQuestion")
                        .HasConstraintName("FK_SurveyQuestionOfferedAnswer_SurveyQuestion1")
                        .IsRequired();

                    b.Navigation("IdOfferedAnswerNavigation");

                    b.Navigation("IdSurveyQuestionNavigation");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.OfferedAnswer", b =>
                {
                    b.Navigation("SurveyQuestionOfferedAnswers");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.Question", b =>
                {
                    b.Navigation("SurveyQuestions");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.QuestionType", b =>
                {
                    b.Navigation("SurveyQuestions");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.Survey", b =>
                {
                    b.Navigation("SurveyQuestions");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.SurveyQuestion", b =>
                {
                    b.Navigation("SurveyQuestionOfferedAnswers");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.SurveyQuestionOfferedAnswer", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("SL.Survey.Entities.Model.SurveyType", b =>
                {
                    b.Navigation("Surveys");
                });
#pragma warning restore 612, 618
        }
    }
}
