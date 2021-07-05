using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Data.Models
{
    [Table("UserLibrary")]
    public class UserLibrary
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual List<Book> Books { get; set; } = new List<Book>();

        public virtual List<ReadProgress> ReadProgresses { get; set; } = new List<ReadProgress>();
    }
}
