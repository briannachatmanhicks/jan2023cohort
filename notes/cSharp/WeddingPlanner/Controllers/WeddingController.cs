using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers;

public class WeddingController : Controller
{
    private MyContext db;
    public WeddingController (MyContext context) {
        db = context;
    }

    //* Show all weddings
    [SessionCheck]
    [HttpGet("/weddings")]
    public IActionResult ShowWeddings()
    {
        List<Wedding> allWeddings = db.Weddings
        .Include (w => w.Attendees)
        .ThenInclude (a => a.User)
        .ToList();
        
        return View("WeddingsList", allWeddings);
    }


    //* Rendering the wedding form
    [SessionCheck]
    [HttpGet("/weddings/new")]
    public IActionResult WedForm()
    {
        return View("New");
    }
    //* Creating a new instance of wedding, if it is not valid, we are going to return the form with errors listed 
    [HttpPost("/weddings/create")]
    public IActionResult CreateWed (Wedding newWed) 
    {
        if(ModelState.IsValid)
        {
            //? Created a one-to-many relationship to have an organizer!
            newWed.UserId = (int)HttpContext.Session.GetInt32("UUID");

            Console.WriteLine("is valid");
            db.Weddings.Add(newWed);
            db.SaveChanges();

            return RedirectToAction("ShowWeddings");
        }
        else{
            return View("New");
        }
    }

    [SessionCheck]
    [HttpGet("weddings/{weddingId}")]
    public IActionResult ShowOne(int weddingId)
    {
        Wedding? wedding = db.Weddings
        .Include(w => w.Attendees)
        .ThenInclude(a => a.User)
        .FirstOrDefault(w => w.WeddingId == weddingId);

        if(wedding == null)
        {
            return RedirectToAction ("ShowWeddings");
        }
        //* this is weird because it did not work without the model wedding, however, ShowOne only has one variable but I am passing a different model >(
        return View ("OneWed", wedding);
    }

    [SessionCheck]
    [HttpPost("/wedding/{weddingId}/rsvp")]
    public IActionResult RSVP (int weddingId)
    {
        UserWedAttend existingRSVP = db.Guests.FirstOrDefault(r => r.UserId ==(int)HttpContext.Session.GetInt32("UUID") && r.WeddingId == weddingId);
        if(existingRSVP != null) 
        {
            db.Guests.Remove(existingRSVP);
            db.SaveChanges();
        } 
        else{
            UserWedAttend newRSVP = new UserWedAttend ()
            {
                WeddingId = weddingId,
                UserId = (int)HttpContext.Session.GetInt32("UUID")
            };
            db.Guests.Add(newRSVP);
            db.SaveChanges();

        }
        return RedirectToAction("ShowWeddings");
        }

}