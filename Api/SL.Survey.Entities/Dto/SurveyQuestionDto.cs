using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.Entities.Dto
{
    public class SurveyQuestionDto
    {
        public int SurveyQuestionId { get; set; }
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public int SortOrder { get; set; }
        public int QuestionTypeId { get; set; }

        public QuestionDto Question { get; set; }
        public SurveyDto Survey { get; set; }
        public SurveyQuestionOfferedAnswerDto SurveyQuestionOfferedAnswers { get; set; }
    }
}
