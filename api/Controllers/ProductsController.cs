/*
 *Carlos Fernandez Jimenez
 *Products api controller
 *Based on Professional ASP.NET Design Patterns Book
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api.Domain;
using api.Domain.Interface;
using api.Model;
using api.ViewModel;//borrar luego
using api.Util;

namespace api.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        // GET api/products
        [HttpGet]
        public IActionResult Get()
        {
            //TodoListResponse<TodoItem> todoListResponse = new TodoListResponse<TodoItem>();
            try
            {
                IList<Product> productEntities = _productService.GetAllProductsFor(0);
                IList<ProductViewModel> products =  productEntities.ConvertToProductListViewModel();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return NotFound(null);
            }
            //return Ok(null);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/products
        [HttpPost]
        public void Post([FromBody]string value)
        {
          
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
