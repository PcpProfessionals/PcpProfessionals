﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BusinessObjects
{
    public class UserBo
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool isValid { get; set; }
        public string Email { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
