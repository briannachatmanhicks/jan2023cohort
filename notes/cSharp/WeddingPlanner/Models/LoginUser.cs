#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models;

[NotMapped] // do not add to the database
public class LoginUser
{
    [Required(ErrorMessage ="Required Field!")]
    [EmailAddress]
    [Display(Name = "Email")]
    public string LoginEmail {get;set;}


    [Required(ErrorMessage ="Required Field!")]
    [DataType(DataType.Password)] //the STARS
    [Display(Name ="Password")]
    public string LoginPassword {get;set;}
}