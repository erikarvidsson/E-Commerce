using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webAPI.Models;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using webAPI.Services;
using webAPI.Models.Repositorys;

namespace webAPI.Controllers
{

    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        private readonly string connectionString;
        private readonly ItemsService itemsService;

        public ItemsController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ConnectionString");
            this.itemsService = new ItemsService(new ItemsRepository(connectionString));
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Items>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var itemsItem = this.itemsService.Get();

            if(itemsItem == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(itemsItem);
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Items), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var itemsItem = this.itemsService.Get(id);

            if (itemsItem == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(itemsItem);
            }

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody]Items items)
        {
            var result = this.itemsService.Add(items);

            if (!result)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public void Delete(int id)
        {
           this.itemsService.Delete(id);

        }
    }


}
