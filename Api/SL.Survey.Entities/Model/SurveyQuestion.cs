using System;
using System.Collections.Generic;

#nullable disable

namespace SL.Survey.Entities.Model
{
    public partial class SurveyQuestion
    {
        public SurveyQuestion()
        {
            SurveyQuestionOfferedAnswers = new HashSet<SurveyQuestionOfferedAnswer>();
        }

        public int IdSurveyQuestion { get; set; }
        public int IdSurvey { get; set; }
        public int IdQuestion { get; set; }
        public int SortOrder { get; set; }
        public int IdQuestionType { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime UpdatedBy { get; set; }

        public virtual Question IdQuestionNavigation { get; set; }
        public virtual QuestionType IdQuestionTypeNavigation { get; set; }
        public virtual Survey IdSurveyNavigation { get; set; }
        public virtual ICollection<SurveyQuestionOfferedAnswer> SurveyQuestionOfferedAnswers { get; set; }
    }
}
