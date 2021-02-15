using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SL.Survey.DataAccess.Migrations
{
    public partial class DBSchema_created : Migration
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
                    OfferedAnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferedAnswer", x => x.OfferedAnswerId);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                schema: "lsurvey",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Question", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "QuestionType",
                schema: "lsurvey",
                columns: table => new
                {
                    QuestionTypeId = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_QuestionType", x => x.QuestionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SurveyType",
                schema: "lsurvey",
                columns: table => new
                {
                    SurveyTypeId = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_SurveyType", x => x.SurveyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SurveyQuestionOfferedAnswer",
                schema: "lsurvey",
                columns: table => new
                {
                    SurveyQuestionOfferedAnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyQuestionId = table.Column<int>(type: "int", nullable: false),
                    OfferedAnswerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyQuestionOfferedAnswer", x => x.SurveyQuestionOfferedAnswerId);
                    table.ForeignKey(
                        name: "FK_SurveyQuestionOfferedAnswer_OfferedAnswer_OfferedAnswerId",
                        column: x => x.OfferedAnswerId,
                        principalSchema: "lsurvey",
                        principalTable: "OfferedAnswer",
                        principalColumn: "OfferedAnswerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Survey",
                schema: "lsurvey",
                columns: table => new
                {
                    SurveyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Instructions = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    OtherInfo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    SurveyTypeId = table.Column<int>(type: "int", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Survey", x => x.SurveyId);
                    table.ForeignKey(
                        name: "FK_Survey_SurveyType_SurveyTypeId",
                        column: x => x.SurveyTypeId,
                        principalSchema: "lsurvey",
                        principalTable: "SurveyType",
                        principalColumn: "SurveyTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                schema: "lsurvey",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyQuestionOfferedAnswerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answer_SurveyQuestionOfferedAnswer_SurveyQuestionOfferedAnswerId",
                        column: x => x.SurveyQuestionOfferedAnswerId,
                        principalSchema: "lsurvey",
                        principalTable: "SurveyQuestionOfferedAnswer",
                        principalColumn: "SurveyQuestionOfferedAnswerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SurveyQuestion",
                schema: "lsurvey",
                columns: table => new
                {
                    SurveyQuestionId = table.Column<int>(type: "int", nullable: false),
                    SurveyId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    QuestionTypeId = table.Column<int>(type: "int", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyQuestion", x => x.SurveyQuestionId);
                    table.ForeignKey(
                        name: "FK_SurveyQuestion_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalSchema: "lsurvey",
                        principalTable: "Question",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SurveyQuestion_QuestionType_QuestionTypeId",
                        column: x => x.QuestionTypeId,
                        principalSchema: "lsurvey",
                        principalTable: "QuestionType",
                        principalColumn: "QuestionTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SurveyQuestion_Survey_SurveyId",
                        column: x => x.SurveyId,
                        principalSchema: "lsurvey",
                        principalTable: "Survey",
                        principalColumn: "SurveyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SurveyQuestion_SurveyQuestionOfferedAnswer_SurveyQuestionId",
                        column: x => x.SurveyQuestionId,
                        principalSchema: "lsurvey",
                        principalTable: "SurveyQuestionOfferedAnswer",
                        principalColumn: "SurveyQuestionOfferedAnswerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_SurveyQuestionOfferedAnswerId",
                schema: "lsurvey",
                table: "Answer",
                column: "SurveyQuestionOfferedAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Survey_SurveyTypeId",
                schema: "lsurvey",
                table: "Survey",
                column: "SurveyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestion_QuestionId",
                schema: "lsurvey",
                table: "SurveyQuestion",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestion_QuestionTypeId",
                schema: "lsurvey",
                table: "SurveyQuestion",
                column: "QuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestion_SurveyId",
                schema: "lsurvey",
                table: "SurveyQuestion",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestionOfferedAnswer_OfferedAnswerId",
                schema: "lsurvey",
                table: "SurveyQuestionOfferedAnswer",
                column: "OfferedAnswerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer",
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
                name: "SurveyQuestionOfferedAnswer",
                schema: "lsurvey");

            migrationBuilder.DropTable(
                name: "SurveyType",
                schema: "lsurvey");

            migrationBuilder.DropTable(
                name: "OfferedAnswer",
                schema: "lsurvey");
        }
    }
}
