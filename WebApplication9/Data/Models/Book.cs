using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication9.Data.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string MainDescription { get; set; }

        [Required]
        public string SmallDescription { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string PdfUrl { get; set; }

        [Required]
        public string BackgroundImage { get; set; }

        [Required]
        public string PublishedDay { get; set; }

        [Required]
        public int Pages { get; set; }

        public virtual List<Author> Authors { get; set; } = new List<Author>();

        public virtual List<Genre> Genres { get; set; } = new List<Genre>();

        public virtual List<BookRating> Ratings { get; set; } = new List<BookRating>();

        public virtual List<Comment> Comments { get; set; } = new List<Comment>();

        public virtual List<UserLibrary> UsersLibraries { get; set; } = new List<UserLibrary>();

        public virtual List<ReadProgress> ReadProgresses { get; set; } = new List<ReadProgress>();
    }
}
