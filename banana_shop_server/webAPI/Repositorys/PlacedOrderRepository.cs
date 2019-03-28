using System;
using System.Collections.Generic;
using Dapper;
using MySql.Data.MySqlClient;
using webAPI.Models;

namespace webAPI.Repositorys
{
    public class PlacedOrderRepository
    {


        private string connectionString;

        public PlacedOrderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public List<Items> Get(int id)

        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.Query<Items>("SELECT * FROM Orders INNER JOIN Customers ON Orders.id = Customer.id WHERE id = @id", new { id }).ToList();
            }
        }


    }
}