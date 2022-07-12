using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomValidationSample.Models
{
    public class Employee
    {
        [Required]
        public string MyName { get; set; }
        [BishnuValidation(ErrorMessage ="address is required")]
        public string Message { get; set; }
    }
}