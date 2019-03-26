using System;
namespace webAPI.Repositorys
{
    public class CartRepository
    {



        private readonly string connectionString;

        public CartRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        //public List<Cart> 
        //{
        //    using (var connection = new MySqlConnection(this.connectionString))
        //    {
        //        var cart =  connection.Query<Cart>("SELECT * FROM items").ToList();


        //    }
        //}


    }
}
