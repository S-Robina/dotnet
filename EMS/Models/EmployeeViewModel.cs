﻿using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class EmployeeViewModel
    {
        [Required]
        public string FirstName { get; set; } = string.Empty; 
        public string LastName { get; set;} = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int? Gender { get; set;}
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PImage { get; set; } = string.Empty;

    }
}
