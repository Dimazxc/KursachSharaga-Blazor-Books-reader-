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

        public virtual List<Author> Authors { get; set; } = new List<Author>();

        public virtual List<Genre> Genres { get; set; } = new List<Genre>();

        public virtual List<BookRating> Ratings { get; set; } = new List<BookRating>();
    }
}
