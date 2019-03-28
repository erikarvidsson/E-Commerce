using Dapper;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using webAPI.Models;

public class CustomersRepository
{
    private readonly string connectionString;

    public CustomersRepository(string connectionString)
    {
        this.connectionString = connectionString;
    }



    public List<Customers> Get()
    {
        using (var connection = new MySqlConnection(this.connectionString))
        {
            return connection.Query<Customers>("SELECT * FROM Customers").ToList();
        }
    }


    public Customers Get(int id)
    {
        using (var connection = new MySqlConnection(this.connectionString))
        {
            return connection.QuerySingleOrDefault<Customers>("SELECT * FROM Customers WHERE id = @id", new { id });

        }

    }

    public bool Add(Customers customers)
    {
        if (true)
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                connection.Execute("INSERT INTO Customers (name, adress, phone) VALUES(@name, @adress, @phone)", customers);
            }
            return false;
        }

    }


    //public void Delete(int id)
    //{
    //    using (var connection = new MySqlConnection(this.connectionString))
    //    {
    //        connection.Execute("DELETE FROM customers WHERE id = @id", new { id });
    //    }

    //}


}
