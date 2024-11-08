﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDWithADONet.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }
        [DisplayName("Date Of Birth")]
        [Required]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Email")]
        [Required]
        public string Email { get; set; }
        public double Salary { get; set; } 
    }
}
