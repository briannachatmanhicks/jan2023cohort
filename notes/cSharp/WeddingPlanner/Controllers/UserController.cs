using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;

namespace WeddingPlanner.Controllers;

public class UserController : Controller
{
    private MyContext db;
    public UserController (MyContext context) {
        db = context;
    }

    
    [HttpGet("/success")]
    public IActionResult TestView()
    {
        return View("test");
    }

    [HttpGet("/weddings")]
    public IActionResult ShowWeddings()
    {
        return View("WeddingsList");
    }

    [HttpPost("/addUser")]
    public IActionResult CreateUser (User newUser)
    {
        if(!ModelState.IsValid)
        {
            return View("test", newUser);
        }
        else
        {
            PasswordHasher<User> hashbrowns = new PasswordHasher<User>();
            newUser.Password = hashbrowns.HashPassword(newUser, newUser.Password);

            db.Users.Add(newUser);
            db.SaveChanges();

            HttpContext.Session.SetInt32("UUID", newUser.UserId);

            return Redirect ("/weddings");
        }
    }

    [HttpPost("/loginUser")]
    public IActionResult Login (LoginUser oldUser) 
    {
    if (ModelState.IsValid)
    {
        User? dataBUser = db.Users.FirstOrDefault(u=> u.Email == oldUser.LoginEmail);
        if (dataBUser == null)
        {
            ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
            return View("test");
        }

        PasswordHasher<LoginUser> hashbrowns = new PasswordHasher<LoginUser> ();
        var passwordresult = hashbrowns.VerifyHashedPassword (oldUser, dataBUser.Password, oldUser.LoginPassword);

        if (passwordresult == 0)
        {
            ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
            return View ("test");
        }

        HttpContext.Session.SetInt32("UUID", dataBUser.UserId);
        return View("WeddingsList");
    }
    else 
    {
        return View("test");
    }
    }

}