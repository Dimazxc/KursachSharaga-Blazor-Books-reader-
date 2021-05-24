using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication9.Data.Models
{
    [Table("BookRating")]
    public class BookRating
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Value { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual Book Book { get; set; }

    }
}
