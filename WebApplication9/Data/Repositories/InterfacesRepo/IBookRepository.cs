using System.Threading.Tasks;
using WebApplication9.Data.Models;

namespace WebApplication9.Data.Repositories.InterfacesRepo
{
    interface IBookRepository : IAsyncRepository<Book>
    {
        Task AddAuthor(Book book, Author author);

        Task AddGenre(Book book, Genre genre);

        Task RemoveAuthor(Book book, Author author);

        Task RemoveGenre(Book book, Genre genre);

        double GetBookRatingsAverage(Book book);
    }
}
