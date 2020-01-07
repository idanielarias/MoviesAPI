using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Services;
namespace MoviesAPI.Controllers
{
     [Route("api/[controller]")]
     public class MoviesController : Controller
     {
          private MoviesDbContext2 _context;
          public MoviesController(MoviesDbContext2 context)
          {
               _context = context;
          }
          public IActionResult GetMovies()
          {
               return Ok(_context.Movies);
          }
     }
}