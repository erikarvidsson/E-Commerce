using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public class ViewPlacedOrder2
    {

        public List<Items> orders { get; set; }
        public Customers customers { get; set; }
    }
}
