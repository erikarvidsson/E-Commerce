using System;
using System.Collections.Generic;
using Dapper;
using System.Linq;
using webAPI.Models;
using Microsoft.Data.Sqlite;
using MySql.Data.MySqlClient;   

namespace webAPI.Repositorys
{
    public class CartRepository
    {
        private readonly string connectionString;

        public CartRepository(string connectionstring)
        {
            this.connectionString = connectionstring;
        }

        public List<Cart> Get()
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.Query<Cart>("SELECT * FROM Cart").ToList();
            }
        }

        public Cart Get(string guid)
        {
            using (MySqlConnection connection = new MySqlConnection(this.connectionString))
            {
                return connection.QuerySingleOrDefault<Cart>("SELECT Cart, COUNT(product_id) AS items FROM Cart WHERE guid = @guid", new { guid });
            }
        }

        public void Add(Cart cart)
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                connection.Execute("INSERT INTO Cart (guid, product_id) VALUES (@guid, @product_id)", cart);
            }
        }
    }
}