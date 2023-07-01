using eCinemas.Data.Base;
using eCinemas.Models;

namespace eCinemas.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
