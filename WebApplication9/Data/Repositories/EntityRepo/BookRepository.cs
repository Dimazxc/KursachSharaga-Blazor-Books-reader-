using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Data.Models;
using WebApplication9.Data.Repositories.InterfacesRepo;

namespace WebApplication9.Data.Repositories.EntityRepo
{
    public class BookRepository : EfRepository<Book>, IBookRepository
    {
        public BookRepository(ApplicationDbContext context) : base(context) { }

        public async Task AddAuthor(Book book, Author author)
        {
            book.Authors.Add(author);
            await Context.SaveChangesAsync();
        }

        public async Task AddGenre(Book book, Genre genre)
        {
            book.Genres.Add(genre);
            await Context.SaveChangesAsync();
        }

        public async Task RemoveAuthor(Book book, Author author)
        {
            book.Authors.Remove(author);
            await Context.SaveChangesAsync();
        }

        public async Task RemoveGenre(Book book, Genre genre)
        {
            book.Genres.Remove(genre);
            await Context.SaveChangesAsync();
        }

        public double GetBookRatingsAverage(Book book) => book.Ratings.DefaultIfEmpty().Average(r => r == null ? 0 : r.Value);
    }
}
