using System;
using System.Collections.Generic;
using webAPI.Models;
using webAPI.Repositorys;

namespace webAPI.Services
{
    public class CartServices
    {
        private readonly CartRepository cartRepository;

        public CartServices(CartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        public List<Cart> Get()
        {
            return this.cartRepository.Get();
        }

        public Cart Get(string guid)
        {
            return this.cartRepository.Get(guid);
        }

        public bool Add(Cart cart)
        {
            if (cart != null)
            {
                this.cartRepository.Add(cart);
                return true;
            }

            return false;
        }
    }
}