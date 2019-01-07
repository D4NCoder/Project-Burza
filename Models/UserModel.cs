﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Burza.Models
{
    public class UserModel
    {
        public string NameAndSurname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PasswordAgain { get; set; }

        public string PhoneNumber { get; set; }

        public bool UserAgreement { get; set; }
    }
}
