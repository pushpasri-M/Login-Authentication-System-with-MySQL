﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration.Models
{
    public class SignIn
    {
        public int Id{ get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}