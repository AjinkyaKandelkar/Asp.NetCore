﻿using System.ComponentModel.DataAnnotations;
using Abp.Auditing;

namespace MyTraining1121AngularDemo.Web.Models.Ui
{
    public class LoginModel
    {
        [Required]
        public string UserNameOrEmailAddress { get; set; }

        [Required]
        [DisableAuditing]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public string TenancyName { get; set; }
    }
}
