using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
//this class contains the busisness logic for the memmbership, i.e. a person needs to be 18 years of old if want to be a
// member except "pay as you go"
namespace Vidli.Models
{
    //this class is derived form validationAttribute
    public class Min18YearsIfAMember : ValidationAttribute
    {
        //we override the IsValid method
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //to access to the containing class which is customer, we need to cast the validationConext for customer too
            var customer = (Customer)validationContext.ObjectInstance;

            //if membership type is "pay as you go" then Bithdate property is valid, so return validationResult as success
            if (customer.MembershipTypeId == MembershipType.Unknown || 
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            //if birthdate is null return error message by instantiating a new validation result
            if (customer.BirthdDate == null)
                return new ValidationResult("Birthdate is required");
            
            //calculate the age of customer
            var age = DateTime.Today.Year - customer.BirthdDate.Value.Year;
            //if the age is 18 or more return success or return an error message
            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("Customer must be al least 18 years old for a membership");

        }
    }
}