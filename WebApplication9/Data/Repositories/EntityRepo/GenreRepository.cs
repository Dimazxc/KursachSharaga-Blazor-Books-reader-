using WebApplication9.Data.Models;
using WebApplication9.Data.Repositories.InterfacesRepo;

namespace WebApplication9.Data.Repositories.EntityRepo
{
    public class GenreRepository : EfRepository<Genre>, IGenreRepository
    {
        public GenreRepository(ApplicationDbContext context) : base(context) { }
    }
}
