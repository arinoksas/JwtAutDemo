﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtAutDemo
{
    [Serializable]
    public class AuthenticationRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
