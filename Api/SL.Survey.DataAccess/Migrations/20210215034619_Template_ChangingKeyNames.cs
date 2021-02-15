using Microsoft.EntityFrameworkCore.Migrations;

namespace SL.Survey.DataAccess.Migrations
{
    public partial class Template_ChangingKeyNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdSurveyType",
                schema: "lsurvey",
                table: "SurveyType",
                newName: "SurveyTypeId");

            migrationBuilder.RenameColumn(
                name: "IdSurveyQuestion",
                schema: "lsurvey",
                table: "SurveyQuestionOfferedAnswer",
                newName: "SurveyQuestionId");

            migrationBuilder.RenameColumn(
                name: "IdOfferedAnswer",
                schema: "lsurvey",
                table: "SurveyQuestionOfferedAnswer",
                newName: "OfferedAnswerId");

            migrationBuilder.RenameColumn(
                name: "IdSurveyQuestionOfferedAnswer",
                schema: "lsurvey",
                table: "SurveyQuestionOfferedAnswer",
                newName: "SurveyQuestionOfferedAnswerId");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyQuestionOfferedAnswer_IdSurveyQuestion",
                schema: "lsurvey",
                table: "SurveyQuestionOfferedAnswer",
                newName: "IX_SurveyQuestionOfferedAnswer_SurveyQuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyQuestionOfferedAnswer_IdOfferedAnswer",
                schema: "lsurvey",
                table: "SurveyQuestionOfferedAnswer",
                newName: "IX_SurveyQuestionOfferedAnswer_OfferedAnswerId");

            migrationBuilder.RenameColumn(
                name: "IdSurvey",
                schema: "lsurvey",
                table: "SurveyQuestion",
                newName: "SurveyId");

            migrationBuilder.RenameColumn(
                name: "IdQuestionType",
                schema: "lsurvey",
                table: "SurveyQuestion",
                newName: "QuestionTypeId");

            migrationBuilder.RenameColumn(
                name: "IdQuestion",
                schema: "lsurvey",
                table: "SurveyQuestion",
                newName: "QuestionId");

            migrationBuilder.RenameColumn(
                name: "IdSurveyQuestion",
                schema: "lsurvey",
                table: "SurveyQuestion",
                newName: "SurveyQuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyQuestion_IdSurvey",
                schema: "lsurvey",
                table: "SurveyQuestion",
                newName: "IX_SurveyQuestion_SurveyId");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyQuestion_IdQuestionType",
                schema: "lsurvey",
                table: "SurveyQuestion",
                newName: "IX_SurveyQuestion_QuestionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyQuestion_IdQuestion",
                schema: "lsurvey",
                table: "SurveyQuestion",
                newName: "IX_SurveyQuestion_QuestionId");

            migrationBuilder.RenameColumn(
                name: "IdSurveyType",
                schema: "lsurvey",
                table: "Survey",
                newName: "SurveyTypeId");

            migrationBuilder.RenameColumn(
                name: "IdSurvey",
                schema: "lsurvey",
                table: "Survey",
                newName: "SurveyId");

            migrationBuilder.RenameIndex(
                name: "IX_Survey_IdSurveyType",
                schema: "lsurvey",
                table: "Survey",
                newName: "IX_Survey_SurveyTypeId");

            migrationBuilder.RenameColumn(
                name: "IdQuestionType",
                schema: "lsurvey",
                table: "QuestionType",
                newName: "QuestionTypeId");

            migrationBuilder.RenameColumn(
                name: "IdQuestion",
                schema: "lsurvey",
                table: "Question",
                newName: "QuestionId");

            migrationBuilder.RenameColumn(
                name: "IdOfferedAnswer",
                schema: "lsurvey",
                table: "OfferedAnswer",
                newName: "OfferedAnswerId");

            migrationBuilder.RenameColumn(
                name: "IdSurveyQuestionOfferedAnswer",
                schema: "lsurvey",
                table: "Answer",
                newName: "SurveyQuestionOfferedAnswerId");

            migrationBuilder.RenameColumn(
                name: "IdAnswer",
                schema: "lsurvey",
                table: "Answer",
                newName: "AnswerId");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_IdSurveyQuestionOfferedAnswer",
                schema: "lsurvey",
                table: "Answer",
                newName: "IX_Answer_SurveyQuestionOfferedAnswerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SurveyTypeId",
                schema: "lsurvey",
                table: "SurveyType",
                newName: "IdSurveyType");

            migrationBuilder.RenameColumn(
                name: "SurveyQuestionId",
                schema: "lsurvey",
                table: "SurveyQuestionOfferedAnswer",
                newName: "IdSurveyQuestion");

            migrationBuilder.RenameColumn(
                name: "OfferedAnswerId",
                schema: "lsurvey",
                table: "SurveyQuestionOfferedAnswer",
                newName: "IdOfferedAnswer");

            migrationBuilder.RenameColumn(
                name: "SurveyQuestionOfferedAnswerId",
                schema: "lsurvey",
                table: "SurveyQuestionOfferedAnswer",
                newName: "IdSurveyQuestionOfferedAnswer");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyQuestionOfferedAnswer_SurveyQuestionId",
                schema: "lsurvey",
                table: "SurveyQuestionOfferedAnswer",
                newName: "IX_SurveyQuestionOfferedAnswer_IdSurveyQuestion");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyQuestionOfferedAnswer_OfferedAnswerId",
                schema: "lsurvey",
                table: "SurveyQuestionOfferedAnswer",
                newName: "IX_SurveyQuestionOfferedAnswer_IdOfferedAnswer");

            migrationBuilder.RenameColumn(
                name: "SurveyId",
                schema: "lsurvey",
                table: "SurveyQuestion",
                newName: "IdSurvey");

            migrationBuilder.RenameColumn(
                name: "QuestionTypeId",
                schema: "lsurvey",
                table: "SurveyQuestion",
                newName: "IdQuestionType");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                schema: "lsurvey",
                table: "SurveyQuestion",
                newName: "IdQuestion");

            migrationBuilder.RenameColumn(
                name: "SurveyQuestionId",
                schema: "lsurvey",
                table: "SurveyQuestion",
                newName: "IdSurveyQuestion");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyQuestion_SurveyId",
                schema: "lsurvey",
                table: "SurveyQuestion",
                newName: "IX_SurveyQuestion_IdSurvey");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyQuestion_QuestionTypeId",
                schema: "lsurvey",
                table: "SurveyQuestion",
                newName: "IX_SurveyQuestion_IdQuestionType");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyQuestion_QuestionId",
                schema: "lsurvey",
                table: "SurveyQuestion",
                newName: "IX_SurveyQuestion_IdQuestion");

            migrationBuilder.RenameColumn(
                name: "SurveyTypeId",
                schema: "lsurvey",
                table: "Survey",
                newName: "IdSurveyType");

            migrationBuilder.RenameColumn(
                name: "SurveyId",
                schema: "lsurvey",
                table: "Survey",
                newName: "IdSurvey");

            migrationBuilder.RenameIndex(
                name: "IX_Survey_SurveyTypeId",
                schema: "lsurvey",
                table: "Survey",
                newName: "IX_Survey_IdSurveyType");

            migrationBuilder.RenameColumn(
                name: "QuestionTypeId",
                schema: "lsurvey",
                table: "QuestionType",
                newName: "IdQuestionType");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                schema: "lsurvey",
                table: "Question",
                newName: "IdQuestion");

            migrationBuilder.RenameColumn(
                name: "OfferedAnswerId",
                schema: "lsurvey",
                table: "OfferedAnswer",
                newName: "IdOfferedAnswer");

            migrationBuilder.RenameColumn(
                name: "SurveyQuestionOfferedAnswerId",
                schema: "lsurvey",
                table: "Answer",
                newName: "IdSurveyQuestionOfferedAnswer");

            migrationBuilder.RenameColumn(
                name: "AnswerId",
                schema: "lsurvey",
                table: "Answer",
                newName: "IdAnswer");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_SurveyQuestionOfferedAnswerId",
                schema: "lsurvey",
                table: "Answer",
                newName: "IX_Answer_IdSurveyQuestionOfferedAnswer");
        }
    }
}
