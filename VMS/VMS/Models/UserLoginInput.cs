﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VMS.Models
{
    public class UserLoginInput
    {
        [Required(ErrorMessage = "Please enter a valid Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a valid Password")]
        public string Password { get; set; }

    }
}
