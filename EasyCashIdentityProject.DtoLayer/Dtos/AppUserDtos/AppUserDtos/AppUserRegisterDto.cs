﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos.AppUserDtos
{
    public class AppUserRegisterDto
    {
       // [Required(ErrorMessage = "Ad alanı zorunludur")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPssword { get; set; }
    }
}
