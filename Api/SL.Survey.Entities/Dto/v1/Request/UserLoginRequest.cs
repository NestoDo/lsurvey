﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SL.Survey.Entities.Dto.v1.Request
{
    public class UserLoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
