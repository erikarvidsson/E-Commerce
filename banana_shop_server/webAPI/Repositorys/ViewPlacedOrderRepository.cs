using System;
using MySql.Data.MySqlClient;
using webAPI.Models;
using webAPI.Models.Repositorys;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Dapper;
using System.Linq;
using System.Collections.Generic;
using StackExchange.Redis;

namespace webAPI.Repositorys
{
    public class ViewPlacedOrderRepository
    {

        private string connectionString;

        public ViewPlacedOrderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public List<ViewPlacedOrder> Get(string guid)

        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.Query<ViewPlacedOrder>("SELECT name, adress, phone FROM Customers WHERE guid = @guid", new { guid }).ToList();
            }
        }


    }
}
