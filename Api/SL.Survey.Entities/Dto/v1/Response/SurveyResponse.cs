using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.Entities.Dto.Response.V1
{
    public class SurveyResponse
    {
        public int SurveyId { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }
        public string OtherInfo { get; set; }
        public int SurveyTypeId { get; set; }
        public bool IsEnabled { get; set; }        
    }
}
