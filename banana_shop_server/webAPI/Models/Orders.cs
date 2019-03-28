using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public class Orders
    {
        public int id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string img_url { get; set; }
        public string description { get; set; }
        public string guid { get; set; }
        public List<Items> items { get; set; }
    }
}
