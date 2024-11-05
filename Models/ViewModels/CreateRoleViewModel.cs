﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]

        public string RoleName { get; set; }
    }
}
