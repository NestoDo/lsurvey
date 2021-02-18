using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.Entities.Dto.Response.V1
{
    public class QuestionTypeResponse
    {
        public int QuestionTypeId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}
