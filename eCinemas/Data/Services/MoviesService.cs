using eCinemas.Data.Base;
using eCinemas.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eCinemas.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext _context;
        public MoviesService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
                .Include(c => c.Cinema)
                .Include(c => c.Producer)
                .Include(c => c.Actors_Movies).ThenInclude(x => x.Actor)
                .FirstOrDefaultAsync(n => n.Id == id);

            return movieDetails;
        }
    }
}
