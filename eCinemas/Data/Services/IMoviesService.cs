using eCinemas.Data.Base;
using eCinemas.Data.ViewModels;
using eCinemas.Models;
using System.Threading.Tasks;

namespace eCinemas.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM movie);
    }
}
