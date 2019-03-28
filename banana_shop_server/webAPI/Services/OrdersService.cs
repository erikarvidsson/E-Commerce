using System;
using System.Collections.Generic;
using webAPI.Repositorys;
using webAPI.Models;

namespace webAPI.Services
{
    public class OrdersService
    {
        private OrdersRepository ordersRepository;

        private OrdersRepository OrdersRepository;

        public OrdersService(OrdersRepository ordersRepository)
        {
            this.ordersRepository = ordersRepository;
        }

        public List<Items> Get(string guid)
        {
            return this.ordersRepository.Get(guid);
        }

    }
}
