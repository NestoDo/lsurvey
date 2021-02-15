using System;
using System.Collections.Generic;

#nullable disable

namespace SL.Survey.Entities.Model
{
    public partial class SurveyQuestionOfferedAnswer
    {
        public SurveyQuestionOfferedAnswer()
        {
            Answers = new HashSet<Answer>();
        }

        public int IdSurveyQuestionOfferedAnswer { get; set; }
        public int IdSurveyQuestion { get; set; }
        public int IdOfferedAnswer { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime UpdatedBy { get; set; }

        public virtual OfferedAnswer IdOfferedAnswerNavigation { get; set; }
        public virtual SurveyQuestion IdSurveyQuestionNavigation { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
