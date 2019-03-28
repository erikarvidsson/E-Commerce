using System;
using MySql.Data.MySqlClient;
using webAPI.Models;
using webAPI.Models.Repositorys;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Dapper;
using System.Linq;
using System.Collections.Generic;

namespace webAPI.Repositorys
{
    public class OrdersRepository
    {

        private string connectionString;

        public OrdersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public List<Items> Get(string guid)

        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.Query<Items>("SELECT * FROM Cart INNER JOIN Items ON Cart.product_id = Items.id WHERE guid = @guid", new { guid }).ToList();
            }
        }


    }
}
