using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Data.Models
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int Likes { get; set; }

        public virtual List<CommentRating> CommentRatings { get; set; } = new List<CommentRating>();
        public virtual Book Book { get; set; }
    }
}
