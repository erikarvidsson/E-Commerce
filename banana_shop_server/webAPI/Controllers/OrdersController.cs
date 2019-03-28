using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using webAPI.Models;
using webAPI.Repositorys;
using webAPI.Services;

namespace webAPI.Controllers
{


        [Route("api/[controller]")]
        public class OrdersController : Controller
        {

        private readonly string connectionString;
        private readonly OrdersService ordersService;

        public OrdersController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ConnectionString");
            this.ordersService = new OrdersService(new OrdersRepository(connectionString));
        }


        [HttpGet("{guid}")]
        [ProducesResponseType(typeof(Orders), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(string guid)
        {
            var resault = ordersService.Get(guid);

             return Ok(resault);

        }
    }
}
