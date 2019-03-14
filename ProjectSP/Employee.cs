using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectSP
{
    public class Employee
    {
        [Required(ErrorMessage = "Please input your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please input your phone number")]
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        [Required(ErrorMessage ="Please input your email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please input your Salary")]
        [Range(0, 10000000000, ErrorMessage =("Data invalid"))]
        public double Salary { get; set; }
    }
}
