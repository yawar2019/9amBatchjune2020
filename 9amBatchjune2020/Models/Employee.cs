using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _9amBatchjune2020.Models
{
    public class Employee
    {
        public int EmpId { get; set; }

        [Required(ErrorMessage = "EmpName is Required")]
        public string  EmpName { get; set; }
        [Range(10000,50000,ErrorMessage ="Range is Between 10000-50000")]
        public int Empsalary { get; set; }

        [Required(ErrorMessage = "Password is Required")]

        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password and Confirm Password Not Match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email is Not Valid")]
        public string Email { get; set; }

        [Required]
        [RegularExpression("^\\d{3}$", ErrorMessage = "Only 3 Digit is allowed")]
        public String Age { get; set; }

        [StringLength(10, ErrorMessage = "Address Can be only 10 Character")]
        public string Address { get; set; }
    }
}