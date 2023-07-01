using eCinemas.Data;
using eCinemas.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eCinemas.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var producers = await _service.GetAllAsync();
            return View(producers);
        }
    }
}
