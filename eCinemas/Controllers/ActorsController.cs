using eCinemas.Data;
using eCinemas.Data.Services;
using eCinemas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace eCinemas.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var actors = await _service.GetAllAsync();
            return View(actors);
        }

        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL", "FullName", "Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.AddAsync(actor);

            return RedirectToAction(nameof(Index)); 
        }



        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetActorByIdAsync(id);

            if(actorDetails == null)
            {
                return View("Empty");
            }

            return View(actorDetails);
        }

    }
}
