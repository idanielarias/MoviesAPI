using Microsoft.AspNetCore.Mvc;
namespace MoviesAPI.Controllers
{
     [Route("/")]
     public class HomeController : Controller
     {
          public IActionResult Index()
          {
               return View();
          }
     }
}