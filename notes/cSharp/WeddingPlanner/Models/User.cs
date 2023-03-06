#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace WeddingPlanner.Models;

public class User {
    [Key]
    public int UserId {get; set;}
    // add more attributes here
    

    [Required (ErrorMessage = "Required Field!")]
    public string FirstName{get;set;}


    [Required (ErrorMessage = "Required Field!")]
    public string LastName{get;set;}


    [Required (ErrorMessage = "Required Field!")]
    [EmailAddress]
    public string Email {get;set;}


    [Required (ErrorMessage = "Required Field!")]
    [MinLength(8, ErrorMessage ="Must be at least 8 characters")]
    public string Password {get;set;}


    [Required (ErrorMessage = "Required Field!")]
    [Compare("Password", ErrorMessage ="Passwords must match.")]
    public string ConfirmPassword{get;set;}

    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

//* required for the many to many relationship
    public List<UserWedAttend> WeddingsAttending {get;set;} = new List<UserWedAttend> ();

//? I created this to be a one to many relationship in order for one organizer to organize many weddings.
    List<Wedding> OrganizedWeddings {get;set;}
}

// public class UniqueEmailAttribute : ValidationAttribute
// {
//     protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
//     {
//         if(value == null)
//         {
//             return new ValidationResult("Email is required!");
//         }
    
//         MyContext _context = (MyContext)validationContext.GetService(typeof(MyContext));
//         // Check to see if there are any records of this email in our database
//         if(_context.Users.Any(e => e.Email == value.ToString()))
//         {
//             return new ValidationResult("Email must be unique!");
//         } else {
//             return ValidationResult.Success;
//         }
//     }
// }