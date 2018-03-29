using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security.Provider;

namespace Vidly.Models
{
    public class Min18YearsIfaMember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = validationContext.ObjectInstance as Customer;

            if(customer.MembershipTypeId==MembershipType.Unknown || customer.MembershipTypeId==MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if(customer.BirthDate==null)
                return new ValidationResult("Birth date is required");

            return DateTime.Now.Year - customer.BirthDate.Value.Year > 18
                ? ValidationResult.Success
                : new ValidationResult("Age should be atleast 18 years to be a member");

        }
    }
}