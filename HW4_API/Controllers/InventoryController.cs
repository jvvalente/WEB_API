using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4_API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace HW4_API.Controllers
{

    [ApiController]
    [Route("Controller")]
    public class InventoryController : ControllerBase
    {

        [HttpGet("test")]
        public string Test()
        {
            return "Hello, World!";
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Product>> Get()
        {
            return Ok(DataContext.Inventory);
        }

    }
}
