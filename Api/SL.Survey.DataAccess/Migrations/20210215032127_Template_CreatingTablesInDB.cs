using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SL.Survey.DataAccess.Migrations
{
    public partial class Template_CreatingTablesInDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "lsurvey");

            migrationBuilder.CreateTable(
                name: "OfferedAnswer",
                schema: "lsurvey",
                columns: table => new
                {
                    IdOfferedAnswer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferedAnswer", x => x.IdOfferedAnswer);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                schema: "lsurvey",
                columns: table => new
                {
                    IdQuestion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.IdQuestion);
                });

            migrationBuilder.CreateTable(
                name: "QuestionType",
                schema: "lsurvey",
                columns: table => new
                {
                    IdQuestionType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionType", x => x.IdQuestionType);
                });

            migrationBuilder.CreateTable(
                name: "SurveyType",
                schema: "lsurvey",
                columns: table => new
                {
                    IdSurveyType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyType", x => x.IdSurveyType);
                });

            migrationBuilder.CreateTable(
                name: "Survey",
                schema: "lsurvey",
                columns: table => new
                {
                    IdSurvey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Instructions = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    OtherInfo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    IdSurveyType = table.Column<int>(type: "int", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Survey", x => x.IdSurvey);
                    table.ForeignKey(
                        name: "FK_Survey_SurveyType",
                        column: x => x.IdSurveyType,
                        principalSchema: "lsurvey",
                        principalTable: "SurveyType",
                        principalColumn: "IdSurveyType",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SurveyQuestion",
                schema: "lsurvey",
                columns: table => new
                {
                    IdSurveyQuestion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSurvey = table.Column<int>(type: "int", nullable: false),
                    IdQuestion = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    IdQuestionType = table.Column<int>(type: "int", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyQuestion", x => x.IdSurveyQuestion);
                    table.ForeignKey(
                        name: "FK_SurveyQuestion_Question",
                        column: x => x.IdQuestion,
                        principalSchema: "lsurvey",
                        principalTable: "Question",
                        principalColumn: "IdQuestion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SurveyQuestion_QuestionType",
                        column: x => x.IdQuestionType,
                        principalSchema: "lsurvey",
                        principalTable: "QuestionType",
                        principalColumn: "IdQuestionType",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SurveyQuestion_Survey",
                        column: x => x.IdSurvey,
                        principalSchema: "lsurvey",
                        principalTable: "Survey",
                        principalColumn: "IdSurvey",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SurveyQuestionOfferedAnswer",
                schema: "lsurvey",
                columns: table => new
                {
                    IdSurveyQuestionOfferedAnswer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSurveyQuestion = table.Column<int>(type: "int", nullable: false),
                    IdOfferedAnswer = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyQuestionOfferedAnswer", x => x.IdSurveyQuestionOfferedAnswer);
                    table.ForeignKey(
                        name: "FK_SurveyQuestionOfferedAnswer_OfferedAnswer1",
                        column: x => x.IdOfferedAnswer,
                        principalSchema: "lsurvey",
                        principalTable: "OfferedAnswer",
                        principalColumn: "IdOfferedAnswer",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SurveyQuestionOfferedAnswer_SurveyQuestion1",
                        column: x => x.IdSurveyQuestion,
                        principalSchema: "lsurvey",
                        principalTable: "SurveyQuestion",
                        principalColumn: "IdSurveyQuestion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                schema: "lsurvey",
                columns: table => new
                {
                    IdAnswer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSurveyQuestionOfferedAnswer = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.IdAnswer);
                    table.ForeignKey(
                        name: "FK_Answer_SurveyQuestionOfferedAnswer",
                        column: x => x.IdSurveyQuestionOfferedAnswer,
                        principalSchema: "lsurvey",
                        principalTable: "SurveyQuestionOfferedAnswer",
                        principalColumn: "IdSurveyQuestionOfferedAnswer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_IdSurveyQuestionOfferedAnswer",
                schema: "lsurvey",
                table: "Answer",
                column: "IdSurveyQuestionOfferedAnswer");

            migrationBuilder.CreateIndex(
                name: "IX_Survey_IdSurveyType",
                schema: "lsurvey",
                table: "Survey",
                column: "IdSurveyType");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestion_IdQuestion",
                schema: "lsurvey",
                table: "SurveyQuestion",
                column: "IdQuestion");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestion_IdQuestionType",
                schema: "lsurvey",
                table: "SurveyQuestion",
                column: "IdQuestionType");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestion_IdSurvey",
                schema: "lsurvey",
                table: "SurveyQuestion",
                column: "IdSurvey");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestionOfferedAnswer_IdOfferedAnswer",
                schema: "lsurvey",
                table: "SurveyQuestionOfferedAnswer",
                column: "IdOfferedAnswer");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestionOfferedAnswer_IdSurveyQuestion",
                schema: "lsurvey",
                table: "SurveyQuestionOfferedAnswer",
                column: "IdSurveyQuestion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer",
                schema: "lsurvey");

            migrationBuilder.DropTable(
                name: "SurveyQuestionOfferedAnswer",
                schema: "lsurvey");

            migrationBuilder.DropTable(
                name: "OfferedAnswer",
                schema: "lsurvey");

            migrationBuilder.DropTable(
                name: "SurveyQuestion",
                schema: "lsurvey");

            migrationBuilder.DropTable(
                name: "Question",
                schema: "lsurvey");

            migrationBuilder.DropTable(
                name: "QuestionType",
                schema: "lsurvey");

            migrationBuilder.DropTable(
                name: "Survey",
                schema: "lsurvey");

            migrationBuilder.DropTable(
                name: "SurveyType",
                schema: "lsurvey");
        }
    }
}
