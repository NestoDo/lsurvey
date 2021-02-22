using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.Entities.Dto.Response.V1
{
    public class SurveyQuestionOfferedAnswerResponse
    {
        public int SurveyQuestionOfferedAnswerId { get; set; }
        public int SurveyQuestionId { get; set; }
        public int OfferedAnswerId { get; set; } 
        public virtual OfferedAnswerResponse OfferedAnswer { get; set; }        
    }
}
