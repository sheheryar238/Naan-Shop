using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tandoor.Models
{
    public class Items
    {
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string image { get; set; }
        [Required]
        public int retail { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}