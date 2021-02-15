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

        public int SurveyQuestionOfferedAnswerId { get; set; }
        public int SurveyQuestionId { get; set; }
        public int OfferedAnswerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime UpdatedBy { get; set; }

        public virtual OfferedAnswer OfferedAnswer { get; set; }
        public virtual SurveyQuestion SurveyQuestion { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
