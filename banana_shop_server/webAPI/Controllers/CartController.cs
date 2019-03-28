using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using webAPI.Models;
using webAPI.Repositorys;
using webAPI.Services;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    public class CartController : Controller
    {
        private readonly string connectionString;
        private readonly CartServices cartsService;
        private readonly CartServices cartService;

        public CartController(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("ConnectionString");
            this.cartService = new CartServices(new CartRepository(connectionString));
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Cart>), StatusCodes.Status200OK)]
        public IActionResult Get()

        {
            return Ok(this.cartService.Get());
        }

        [HttpGet("{guid}")]
        [ProducesResponseType(typeof(Cart), StatusCodes.Status200OK)]
        [ProducesResponseTypeAttribute(StatusCodes.Status404NotFound)]
        public IActionResult Get(string guid)
        {
            var resault = this.cartService.Get(guid);
            return Ok(resault);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody]Cart cart)
        {
            var result = this.cartService.Add(cart);

            if (!result)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Cart), StatusCodes.Status200OK)]
        [ProducesResponseTypeAttribute(StatusCodes.Status404NotFound)]
        public void Delete(int id)
        {

        }
    }
}
