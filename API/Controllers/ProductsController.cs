using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController] //marking controller class
    [Route("api/[controller]")]
    //[controller] will replaced controller which we define below
    public class ProductsController : ControllerBase
    //inheritng .Net.Core.MVC     
    // http://localhost:5001/api/products
    {
        [HttpGet]
        public string GetProducts()
        {
            return "List of products";
        }
        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "Single product ";
        }



    }
}