using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tandoor.Models
{
    public class OrderItems
    {
        public int Id { get; set; }

        [Required]
        public Items Items { get; set; }
        public int ItemsId { get; set; }

        public Order Order { get; set; }
        public int OrderId { get; set; }
    }
}