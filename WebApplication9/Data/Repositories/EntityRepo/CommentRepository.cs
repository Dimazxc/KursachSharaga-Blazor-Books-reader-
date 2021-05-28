using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Data.Models;
using WebApplication9.Data.Repositories.InterfacesRepo;

namespace WebApplication9.Data.Repositories.EntityRepo
{
    public class CommentRepository : EfRepository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext context) : base(context) { }
    }
}
