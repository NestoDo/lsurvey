using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.Entities.Dto
{
    public class QuestionDto
    {
        public int QuestionId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public  ICollection<SurveyQuestionDto> SurveyQuestions { get; set; }
    }
}
