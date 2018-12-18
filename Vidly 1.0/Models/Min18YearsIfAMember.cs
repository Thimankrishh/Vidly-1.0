using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_1._0.Models
{
    public class Min18YearsIfAMember : ValidationAttribute // derive this class in validation attribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if ( customer.MembershipTypeId == MembershipType.Unknown || 
                 customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
             
            if (customer.Birthdate == null)
            {
                return new ValidationResult("Birth Date Is Required!");
            }

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer Should Be At Least 18 Year Old To Go On A Membership.");
                
        }
    }
}