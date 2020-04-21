using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project_APIs.Models;
using Project_APIs.DAL;
using Project_APIs.DAL.Interfaces;

namespace Project_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductDAL _productDAL;

        public ProductsController(IProductDAL productDAL)
        {
            _productDAL = productDAL ?? throw new ArgumentNullException(nameof(productDAL));
        }

        [HttpPost]
        public IActionResult Create([FromBody]Product product)
        {
            _productDAL.Insert(product);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> products = _productDAL.GetAll();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Product product = _productDAL.GetById(id);

            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult Modify(int id, [FromBody]Product product)
        {
            _productDAL.Update(id, product);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productDAL.Delete(id);

            return Ok();
        }
    }
}