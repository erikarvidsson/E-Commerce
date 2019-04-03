using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public class PlacedOrder
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public int customerId { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public int guid { get; set; }

    }
}
