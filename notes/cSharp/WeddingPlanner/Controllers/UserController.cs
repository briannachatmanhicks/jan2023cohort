using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WeddingPlanner.Controllers;

public class UserController : Controller
{
    private MyContext db;
    public UserController (MyContext context) {
        db = context;
    }

    
    [HttpGet("")]
    public IActionResult TestView()
    {
        return View("test");
    }

    [HttpPost("/addUser")]
    public IActionResult CreateUser (User newUser)
    {
        if(!ModelState.IsValid)
        {
            return View("test");
        }
        else
        {
            PasswordHasher<User> hashbrowns = new PasswordHasher<User>();
            newUser.Password = hashbrowns.HashPassword(newUser, newUser.Password);

            db.Users.Add(newUser);
            db.SaveChanges();

            HttpContext.Session.SetInt32("UUID", newUser.UserId);
            HttpContext.Session.SetString("name", " " + newUser.FirstName);

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
        HttpContext.Session.SetString("name", " " + dataBUser.FirstName);
        return Redirect("/weddings");
    }
    else 
    {
        return View("test");
    }
    }

    [HttpPost("/logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("TestView");
    }

}

public class SessionCheckAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        // Find the session, but remember it may be null so we need int?
        int? userId = context.HttpContext.Session.GetInt32("UUID");
        // Check to see if we got back null
        if(userId == null)
        {
            // Redirect to the Index page if there was nothing in session
            // "Home" here is referring to "HomeController", you can use any controller that is appropriate here
            context.Result = new RedirectToActionResult("TestView", "User", null);
        }
    }
}