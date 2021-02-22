using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.Entities.Dto.v1.Response
{
    public class AuthFailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
