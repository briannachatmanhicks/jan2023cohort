#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using WeddingPlanner.Models;

public class UserWedAttend 
{
    [Key]
    public int UserWedAttendId {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    //* required for the many to many relationship
    public int UserId {get;set;}
    public User? User {get;set;}
    public int WeddingId {get;set;}
    public Wedding? Wedding {get;set;}

}