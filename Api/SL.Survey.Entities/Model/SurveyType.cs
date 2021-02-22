using System;
using System.Collections.Generic;

#nullable disable

namespace SL.Survey.Entities.Model
{
    public partial class SurveyType
    {
        public SurveyType()
        {
            Surveys = new HashSet<Survey>();
        }

        public int SurveyTypeId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime UpdatedBy { get; set; }

        public virtual ICollection<Survey> Surveys { get; set; }
    }
}
