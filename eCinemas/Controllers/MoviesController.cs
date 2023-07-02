using eCinemas.Data;
using eCinemas.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eCinemas.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;

        }
        public async Task<IActionResult> Index()
        {
            var movies = await _service.GetAllAsync(n => n.Cinema);

            return View(movies);
        }

        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetMovieByIdAsync(id);
            return View(movieDetail);
        }
    }
}
