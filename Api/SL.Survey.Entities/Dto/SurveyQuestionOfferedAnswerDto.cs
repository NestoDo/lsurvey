using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.Entities.Dto
{
    public class SurveyQuestionOfferedAnswerDto
    {
        public int SurveyQuestionOfferedAnswerId { get; set; }
        public int SurveyQuestionId { get; set; }
        public int OfferedAnswerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime UpdatedBy { get; set; }

        public virtual OfferedAnswerDto OfferedAnswer { get; set; }        
    }
}
