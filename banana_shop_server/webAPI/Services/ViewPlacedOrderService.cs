using System;
using System.Collections.Generic;
using webAPI.Repositorys;
using webAPI.Models;
using StackExchange.Redis;

namespace webAPI.Services
{
    public class ViewPlacedOrderService
    {
        private ViewPlacedOrderRepository viewPlacedOrderRepository;

        private ViewPlacedOrderRepository ViewPlacedOrderRepository;

        public ViewPlacedOrderService(ViewPlacedOrderRepository viewPlacedOrderRepository)
        {
            this.viewPlacedOrderRepository = viewPlacedOrderRepository;
        }

        public List<ViewPlacedOrder> Get(string guid)
        {
            return this.viewPlacedOrderRepository.Get(guid);
        }
    }
}
