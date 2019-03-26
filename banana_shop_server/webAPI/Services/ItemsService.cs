using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using webAPI.Models.Repositorys;
using System.Collections.Generic;
using webAPI.Models;

namespace webAPI.Services
{
    public class ItemsService
    {
        private readonly ItemsRepository itemsRepository;

        public ItemsService(ItemsRepository ItemsRepository)
        {
            this.itemsRepository = ItemsRepository;
        }

        public List<Items> Get()
        {
            return this.itemsRepository.Get();
        }


        public Items Get(int id)
        {
            return this.itemsRepository.Get(id);

        }

        public bool Add(Items items)
        {

            if (string.IsNullOrEmpty(items.name) || string.IsNullOrEmpty(items.description))
            {
                return false;
            }
            this.itemsRepository.Add(items);
            return true;
        }

        public void Delete(int id)
        {
            this.itemsRepository.Delete(id);
        }
    }
}
