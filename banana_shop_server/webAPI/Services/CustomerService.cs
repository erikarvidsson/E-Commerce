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
    public class CustomersService
    {
        private readonly CustomersRepository customersRepository;


        public CustomersService(CustomersRepository CustomersRepository)
        {
            this.customersRepository = CustomersRepository;
        }

        public List<Customers> Get()
        {
            return this.customersRepository.Get();
        }


        public Customers Get(int id)
        {
            return this.customersRepository.Get(id);

        }

        public bool Add(Customers customers)
        {

            if (string.IsNullOrEmpty(customers.name) || string.IsNullOrEmpty(customers.adress))
            {
                return false;
            }
            this.customersRepository.Add(customers);
            return true;
        }

        //public void Delete(int id)
        //{
        //    this.customersRepository.Delete(id);
        //}
    }
}
