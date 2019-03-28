using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public class Cart
    {
        public string guid { get; set; }
        public int product_id { get; set; }
        public bool orderd { get; set; }
    }
}
