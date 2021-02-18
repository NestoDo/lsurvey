using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.Entities.Dto.Response.V1
{
    public class SurveyQuestionResponse
    {
        public int SurveyQuestionId { get; set; }
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public int SortOrder { get; set; }
        public int QuestionTypeId { get; set; }

        public QuestionResponse Question { get; set; }
        public SurveyResponse Survey { get; set; }
        public SurveyQuestionOfferedAnswerResponse SurveyQuestionOfferedAnswers { get; set; }
    }
}
