using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Data.Models;
using WebApplication9.Data.Repositories.InterfacesRepo;

namespace WebApplication9.Data.Repositories.EntityRepo
{
    public class CommentRatingRepository : EfRepository<CommentRating>, ICommentRatingRepository
    {
        public CommentRatingRepository(ApplicationDbContext context) : base(context) { }
    }
}
