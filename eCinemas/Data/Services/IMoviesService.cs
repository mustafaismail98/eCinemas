using eCinemas.Data.Base;
using eCinemas.Models;
using System.Threading.Tasks;

namespace eCinemas.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
    }
}
