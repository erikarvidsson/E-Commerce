using System;
using System.Collections.Generic;
using Dapper;
using System.Linq;
using webAPI.Models;
using Microsoft.Data.Sqlite;
using MySql.Data.MySqlClient;   

namespace webAPI.Repositorys
{
    public class CartItemsRepository
    {
        private readonly string connectionString;

        public CartItemsRepository(string connectionstring)
        {
            this.connectionString = connectionstring;
        }

        public List<CartItems> Get()
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.Query<CartItems>("SELECT * FROM Cart").ToList();
            }
        }

        public CartItems Get(string guid)
        {
            using (MySqlConnection connection = new MySqlConnection(this.connectionString))
            {
                return connection.QuerySingleOrDefault<CartItems>("SELECT Cart, COUNT(product_id) AS items FROM Cart WHERE guid = @guid", new { guid });
            }
        }

        public void Add(CartItems cartItems)
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                connection.Execute("INSERT INTO Cart (guid, product_id) VALUES (@guid, @product_id)", cartItems);
            }
        }
    }
}