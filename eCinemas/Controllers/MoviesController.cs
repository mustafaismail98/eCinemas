﻿using eCinemas.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eCinemas.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext appDbContext)
        {
            _context = appDbContext;

        }
        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies.Include(c => c.Cinema).OrderBy(x => x.Name).ToListAsync();

            return View(movies);
        }
    }
}