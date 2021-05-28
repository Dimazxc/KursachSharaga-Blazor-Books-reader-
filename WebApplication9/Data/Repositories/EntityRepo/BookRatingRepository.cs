using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Data.Models;
using WebApplication9.Data.Repositories.InterfacesRepo;

namespace WebApplication9.Data.Repositories.EntityRepo
{
    public class BookRatingRepository : EfRepository<BookRating>, IBookRatingRepository
    {
        public BookRatingRepository(ApplicationDbContext context) : base(context) { }
    }
}
