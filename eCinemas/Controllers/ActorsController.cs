using eCinemas.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eCinemas.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IActionResult Index()
        {
            var actors = _context.Actors.ToList();
            return View(actors);
        }
    }
}
