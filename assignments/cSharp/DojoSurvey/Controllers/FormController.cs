using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;
    public class FormController : Controller
    {
        [HttpGet("/results")]
        public ViewResult Results() {
            return View();
        }

        [HttpPost("/results")]
        public IActionResult Method (string Name, )
    }