using System;
using System.Collections.Generic;

#nullable disable

namespace SL.Survey.Entities.Model
{
    public partial class QuestionType
    {
        public QuestionType()
        {
            SurveyQuestions = new HashSet<SurveyQuestion>();
        }

        public int QuestionTypeId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime UpdatedBy { get; set; }

        public virtual ICollection<SurveyQuestion> SurveyQuestions { get; set; }
    }
}
