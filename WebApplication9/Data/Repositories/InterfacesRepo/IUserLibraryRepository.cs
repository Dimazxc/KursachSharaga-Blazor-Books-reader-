using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Data.Models;

namespace WebApplication9.Data.Repositories.InterfacesRepo
{
    public interface IUserLibraryRepository : IAsyncRepository<UserLibrary>
    {
        Task AddBookToLib(UserLibrary userLibrary, Book book);
    }
}
