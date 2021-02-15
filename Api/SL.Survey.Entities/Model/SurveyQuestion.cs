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

        public int SurveyQuestionId { get; set; }
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public int SortOrder { get; set; }
        public int QuestionTypeId { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime UpdatedBy { get; set; }

        public virtual Question QuestionNavigationId { get; set; }
        public virtual QuestionType QuestionTypeIdNavigation { get; set; }
        public virtual Survey SurveyIdNavigation { get; set; }
        public virtual ICollection<SurveyQuestionOfferedAnswer> SurveyQuestionOfferedAnswers { get; set; }
    }
}
