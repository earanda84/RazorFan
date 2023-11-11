using Microsoft.AspNetCore.Mvc;

namespace RazorFan.Controllers;


public class RazorController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View("Index");
    }
}