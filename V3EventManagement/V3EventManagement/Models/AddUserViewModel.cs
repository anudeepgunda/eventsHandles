﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace V3EventManagement.Models
{
    public class AddUserViewModel
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}