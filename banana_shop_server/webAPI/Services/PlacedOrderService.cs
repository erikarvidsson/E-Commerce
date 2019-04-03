using System;
using webAPI.Models;
using webAPI.Repositorys;
using System.Collections.Generic;

namespace webAPI.Services
{
    public class PlacedOrderService
    {
        private object placedOrdersRepository;

        private PlacedOrderRepository placedOrderRepository;

        public PlacedOrderService(PlacedOrderRepository placedOrderRepository)
        {
            this.placedOrderRepository = placedOrderRepository;
        }

        public List<PlacedOrder> Get(string guid)
        {
            return this.placedOrderRepository.Get(guid);

        }

        public bool Add(Customers customer)
        {
            if (customer != null)
            {
                this.placedOrderRepository.Add(customer);
                return true;
            }
            return false;
        }
    }
}
