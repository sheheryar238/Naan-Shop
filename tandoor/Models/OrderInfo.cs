using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tandoor.Models
{
    public class OrderInfo
    {
        public int Id { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string customer_name { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }

    }
}