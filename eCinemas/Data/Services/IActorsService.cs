using eCinemas.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eCinemas.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetActorByIdAsync(int id);
        Task AddAsync(Actor actor);
        Actor UpdateActor(int id, Actor newActor);
        void Delete(int id);
    }
}
