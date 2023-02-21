using Microsoft.AspNetCore.Mvc;
namespace BasicWebReviewI.Controllers;     //be sure to use your own project's namespace!
    public class RootController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public string Index()
        {
            return "Hello World from the Home Controller!";
        }
    }