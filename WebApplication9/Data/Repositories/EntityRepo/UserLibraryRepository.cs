using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Data.Models;
using WebApplication9.Data.Repositories.InterfacesRepo;

namespace WebApplication9.Data.Repositories.EntityRepo
{
    public class UserLibraryRepository : EfRepository<UserLibrary>, IUserLibraryRepository
    {
        public UserLibraryRepository(ApplicationDbContext context) : base(context) { }

        public async Task AddBookToLib(UserLibrary userLibrary, Book book)
        {
            userLibrary.Books.Add(book);
            await Context.SaveChangesAsync();
        }
    }
}
