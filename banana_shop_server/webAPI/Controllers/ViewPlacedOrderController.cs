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
        public class ViewPlacedOrderController : Controller
        {

            private readonly string connectionString;
            private readonly ViewPlacedOrderService viewPlacedOrderService;

            public ViewPlacedOrderController(IConfiguration configuration)
            {
                var connectionString = configuration.GetConnectionString("ConnectionString");
                this.viewPlacedOrderService = new ViewPlacedOrderService(new ViewPlacedOrderRepository(connectionString));
            }




        [HttpGet("{guid}")]
            [ProducesResponseType(typeof(Orders), StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public IActionResult Get(string guid)
            {
                var resault = viewPlacedOrderService.Get(guid);

                return Ok(resault);

            }
        }
    }

