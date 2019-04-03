using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using webAPI.Models;
using webAPI.Repositorys;
using webAPI.Services;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    public class PlacedOrderController : Controller
    {

        private readonly string connectionString;
        private readonly PlacedOrderService placedOrderService;

        public PlacedOrderController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ConnectionString");
            this.placedOrderService = new PlacedOrderService(new PlacedOrderRepository(connectionString));
        }


        [HttpGet("{guid}")]
        [ProducesResponseType(typeof(PlacedOrder), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(string guid)
        {
            var resault = this.placedOrderService.Get(guid);

            return Ok(resault);

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody]Customers customer)
        {
            var result = this.placedOrderService.Add(customer);

            return !result ? BadRequest() : (IActionResult)Ok();
        }

    }
}

