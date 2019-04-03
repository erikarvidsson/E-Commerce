using System;
using System.Collections.Generic;
using System.Web.Http;
using StackExchange.Redis;
using webAPI.Models;
using webAPI.Repositorys;

namespace webAPI.Services
{
    public class ViewPlacedOrder2Service
    {
        private CustomersRepository customersRepository;
        private OrdersRepository ordersRepository;

        public ViewPlacedOrder2Service(CustomersRepository customersRepository, OrdersRepository ordersRepository)
        {
            this.customersRepository = customersRepository;
            this.ordersRepository = ordersRepository;

        }

        public ViewPlacedOrder2 Get(string guid)
        {
            var customers = this.customersRepository.Get(guid);
            var orders = this.ordersRepository.Get(guid);

            return new ViewPlacedOrder2
            {
                customers = customers,
                orders = orders,
            };
        }
    }
}