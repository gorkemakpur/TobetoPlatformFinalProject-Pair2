﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Auth.Request
{
    public class UpdatePasswordAuthRequest
    {
        public string CurrentPassword { get; set; }
        public string Password { get; set; }
        public string PasswordRepeat { get; set; }
    }
}
