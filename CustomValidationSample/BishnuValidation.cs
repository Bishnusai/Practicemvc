using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomValidationSample
{
    public class BishnuValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value!=null)
            {
                string message = value.ToString();
                if (message.Contains("Bishnu"))
                {
                    return ValidationResult.Success;
                }  
            }

            return new ValidationResult("Field must contain Bishnu");
        }
    }
}