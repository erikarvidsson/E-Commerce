using Dapper;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using webAPI.Models;

public class ItemsRepository
{
    private readonly string connectionString;

    public ItemsRepository(string connectionString)
    {
        this.connectionString = connectionString; 
        }



    public List<Items> Get()
    {
        using (var connection = new MySqlConnection(this.connectionString))
        {
            return connection.Query<Items>("SELECT * FROM Items").ToList();
        }
    }


    public Items Get(int id)
    {
        using (var connection = new MySqlConnection(this.connectionString))
        {
            return connection.QuerySingleOrDefault<Items>("SELECT * FROM Items WHERE id = @id", new { id });

        }

    }

    public bool Add(Items items)
    {
        if (true)
        {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                connection.Execute("INSERT INTO Products (name, price, description) VALUES(@name, @price, @description)", items);
            }
            return false;
        }

    }


    public void Delete(int id)
    {
            using (var connection = new MySqlConnection(this.connectionString))
            {
                connection.Execute("DELETE FROM items WHERE id = @id", new { id });
            }

    }


    //public void Delete(int id)
    //{
    //    using (var connection = new MySqlConnection(this.connectionString))
    //    {

    //        connection.Execute("DELETE FROM News WHERE id = @id", new { id });

    //    }
    //}

}
