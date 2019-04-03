using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using webAPI.Services;
using webAPI.Models;
using webAPI.Repositorys;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    public class ViewPlacedOrder2Controller : Controller
    {

        private readonly string connectionString;
        private readonly ViewPlacedOrder2Service viewPlacedOrderService;
        private ViewPlacedOrder2Service viewPlacedOrder2Service;

        public ViewPlacedOrder2Controller(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ConnectionString");
            this.viewPlacedOrder2Service = new ViewPlacedOrder2Service(new CustomersRepository(connectionString), new OrdersRepository(connectionString));
        }

        [HttpGet("{guid}")]
        [ProducesResponseType(typeof(ViewPlacedOrder2), StatusCodes.Status200OK)]
        [ProducesResponseTypeAttribute(StatusCodes.Status404NotFound)]
        public IActionResult Get(string guid)
        {
            return Ok(this.viewPlacedOrder2Service.Get(guid));
        }
    }
}