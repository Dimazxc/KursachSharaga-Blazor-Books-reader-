using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Data.Models
{
    public class ReadProgress
    {
        [Key]
        public int Id { get; set; }

        public virtual UserLibrary UserLibrary { get; set; }

        public virtual Book Book { get; set; }

        public int CurrentBookPage { get; set; }
    }
}
