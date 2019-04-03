using System;
namespace webAPI.Models
{
    public class ViewPlacedOrder
    {
        public string name { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }

        public string price { get; set; }
        public string img_url { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
    }
}
