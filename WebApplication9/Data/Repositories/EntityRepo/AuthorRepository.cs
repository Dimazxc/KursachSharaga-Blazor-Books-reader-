using WebApplication9.Data.Models;
using WebApplication9.Data.Repositories.InterfacesRepo;

namespace WebApplication9.Data.Repositories.EntityRepo
{
    public class AuthorRepository : EfRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationDbContext context) : base(context) { }
    }
}
