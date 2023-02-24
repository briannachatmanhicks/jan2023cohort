#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using DateValidator.Models;

namespace DateValidator.Models;

public class User {
    [Required (ErrorMessage="This field is required")]
    public string FirstName{get;set;}

    [Required (ErrorMessage="This field is required")]
    public string LastName{get;set;}

    // [FutureDate]
    public DateTime? DOB {get;set;}


}


// public class FutureDateAttribute : ValidationAttribute{
// protected override ValidationResult IsValid(object value, ValidationContext validationContext){
//     // DateTime DOB;
//         if (value is DateTime){  
//             return new ValidationResult("Custom error message");}
//         else{
//             return ValidationResult.Success; }    
//     }
// }
