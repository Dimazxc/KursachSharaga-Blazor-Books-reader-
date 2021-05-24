using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication9.Data.Models;

namespace WebApplication9.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<BookRating> BookRatings { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<CommentRating> CommentRatings { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-WebApplication9-AE458A3D-F164-4E80-AA3B-2EE9DCED4A1A;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
