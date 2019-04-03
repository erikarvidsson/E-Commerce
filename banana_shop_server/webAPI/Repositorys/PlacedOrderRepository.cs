using System;
using System.Collections.Generic;
using System.Linq;
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


        public List<PlacedOrder> Get(string guid)

        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                return connection.Query<PlacedOrder>("SELECT * FROM Cart WHERE guid = @guid", new { guid }).ToList();
            }
        }

        public bool Add( Customers customer )
        {
            if (true)
            {
                using (var connection = new MySqlConnection(this.connectionString))
                {
                    connection.Execute("INSERT INTO Customers (name, adress, phone, guid) VALUES(@name, @adress, @phone, @guid)", customer );
                    connection.Execute("INSERT INTO PlacedOrder (guid) VALUES (@guid)", customer );
                    connection.Execute("UPDATE cart SET orderd = 1 WHERE guid = @guid", customer );
                }
                return false;
            }

        }
    }


  }
