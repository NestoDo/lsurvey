using System;
using System.Collections.Generic;

#nullable disable

namespace SL.Survey.Entities.Model
{
    public partial class Answer
    {
        public int AnswerId { get; set; }
        public int SurveyQuestionOfferedAnswerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime UpdatedBy { get; set; }

        public virtual SurveyQuestionOfferedAnswer SurveyQuestionOfferedAnswerIdNavigation { get; set; }
    }
}
