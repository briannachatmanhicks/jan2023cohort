#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
namespace WeddingPlanner.Models; 

public class Wedding 
{
    [Key]
    public int WeddingId {get;set;}

    [Required (ErrorMessage = "Required Field!")]
    public string WedderOne {get;set;}


    [Required (ErrorMessage = "Required Field!")]
    public string WedderTwo {get;set;}


    [Required (ErrorMessage = "Required Field!")]
    [FutureDate]
    public DateTime Date {get;set;}


    [Required (ErrorMessage = "Required Field!")]
    public string Address {get;set;}

    public DateTime CreatedAt = DateTime.Now;
    public DateTime UpdatedAt = DateTime.Now;

    public List<UserWedAttend> Attendees {get;set;} = new List<UserWedAttend>();

    //? I created this to be a one to many relationship in order for one organizer to create many weddings.
    public int UserId {get;set;}
    public User? Organizer {get;set;}

}

public class FutureDateAttribute : ValidationAttribute{
protected override ValidationResult IsValid(object value, ValidationContext validationContext){
    DateTime CurrentTime = DateTime.Now;
        if (((DateTime)value) < CurrentTime) {  
            Console.WriteLine(CurrentTime);
            return new ValidationResult("The date has to be in the future");}
        else{
            return ValidationResult.Success; }    
    }
}
