﻿//custom validaiton attribute

using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrepForOnSite.Models
{
    public class DobAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object Dob, ValidationContext validationContext)
        {
            Person person = (Person)validationContext.ObjectInstance;
            if (DateTime.Now.Year-person.Dob.Year > 18)
                return ValidationResult.Success;
            else
                return new ValidationResult("Age must be more then 18!");
        }

        ////only for jquery unobtrusive validation
        //public void AddValidation(ClientModelValidationContext context)
        //{
        //    context.Attributes.Add("data-val", "true");
        //    context.Attributes.Add("data-val-dob", "Age has to be more then 18");
        //}
    }
}
