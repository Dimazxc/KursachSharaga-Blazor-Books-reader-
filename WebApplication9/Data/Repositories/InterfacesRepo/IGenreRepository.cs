using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication9.Data.Models;

namespace WebApplication9.Data.Repositories.InterfacesRepo
{
    interface IGenreRepository : IAsyncRepository<Genre>
    {
        Task<IEnumerable<string>> GetByName();
    }
}
