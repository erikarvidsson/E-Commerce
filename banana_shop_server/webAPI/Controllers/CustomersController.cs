using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using webAPI.Models;
using webAPI.Services;

namespace webAPI.Controllers
{

        [Route("api/[controller]")]
        public class CustomersController : Controller
        {
            private readonly string connectionString;
            private readonly CustomersService customersService;

            public CustomersController(IConfiguration configuration)
            {
                var connectionString = configuration.GetConnectionString("ConnectionString");
                this.customersService = new CustomersService(new CustomersRepository(connectionString));
            }

            [HttpGet]
            [ProducesResponseType(typeof(List<Customers>), StatusCodes.Status200OK)]
            public IActionResult Get()
            {
                var customersItem = this.customersService.Get();

                if (customersItem == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(customersItem);
                }
            }

            [HttpGet("{id}")]
            [ProducesResponseType(typeof(Customers), StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public IActionResult Get(int id)
            {
                var customersItem = this.customersService.Get(id);

                if (customersItem == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(customersItem);
                }

            }

            [HttpPost]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult Post([FromBody]Customers customers)
            {
                var result = this.customersService.Add(customers);

                if (!result)
                {
                    return BadRequest();
                }

                return Ok();
            }

            //[HttpDelete("{id}")]
            //[ProducesResponseType(StatusCodes.Status200OK)]
            //[ProducesResponseType(StatusCodes.Status404NotFound)]
            //public void Delete(int id)
            //{
            //    this.customersService.Delete(id);

            //}
        }
    }

