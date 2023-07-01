using eCinemas.Data.Base;
using eCinemas.Models;

namespace eCinemas.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
