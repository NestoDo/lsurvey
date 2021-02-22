using System;
using System.Collections.Generic;

#nullable disable

namespace SL.Survey.Entities.Model
{
    public partial class OfferedAnswer
    {
        public OfferedAnswer()
        {
            SurveyQuestionOfferedAnswers = new HashSet<SurveyQuestionOfferedAnswer>();
        }

        public int OfferedAnswerId { get; set; }
        public string Answer { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime UpdatedBy { get; set; }

        public virtual ICollection<SurveyQuestionOfferedAnswer> SurveyQuestionOfferedAnswers { get; set; }
    }
}
