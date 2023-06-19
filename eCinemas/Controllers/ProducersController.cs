using eCinemas.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eCinemas.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            var producers = await _context.Producers.ToListAsync();
            return View(producers);
        }
    }
}
