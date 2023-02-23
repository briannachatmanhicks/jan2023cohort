using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWModel.Models;

namespace DojoSurveyWModel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("survey")]
    public IActionResult Submission(Survey yourSurvey)
    {
        return View("Survey", yourSurvey);
    }

    // [HttpPost("survey")]
    // public IActionResult Submission(Survey yourSurvey)
    // {
    //     if (ModelState.IsValid)                  another way to do this but I need to understand how to do this
    //     {
    //         return View("Survey", yourSurvey);
    //     }
    //     else
    //     {
    //         return View("Index");
    //     }
    // }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
