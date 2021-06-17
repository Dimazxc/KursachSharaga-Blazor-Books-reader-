using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication9.Data.Models
{
    [Table("Author")]
    public class Author
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string MainDescription { get; set; }

        [Required]
        public string SmallDescription { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string BiographyUrl { get; set; }

        [Required]
        public string YearsOfLife { get; set; }

        public virtual List<Book> Books { get; set; } = new List<Book>();
    }
}
