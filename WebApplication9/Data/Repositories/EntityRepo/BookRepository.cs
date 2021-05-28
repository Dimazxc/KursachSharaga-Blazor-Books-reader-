using WebApplication9.Data.Models;
using WebApplication9.Data.Repositories.InterfacesRepo;

namespace WebApplication9.Data.Repositories.EntityRepo
{
    public class BookRepository : EfRepository<Book>, IBookRepository
    {
        public BookRepository(ApplicationDbContext context) : base(context) { }
    }
}
