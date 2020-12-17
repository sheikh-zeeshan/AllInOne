using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLProj.Interfaces;
using GraphQLProj.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GraphQLProj.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class ProductsController : ControllerBase
    //{

    //    IProduct _prodService;
    //    public ProductsController(IProduct productService)
    //    {
    //        _prodService = productService;
    //    }

    //    // GET: api/<ProductsController>
    //    [HttpGet]
    //    public IEnumerable<Product> Get()
    //    {
    //        return _prodService.GetAllProducts();
    //    }

    //    // GET api/<ProductsController>/5
    //    [HttpGet("{id}")]
    //    public Product Get(int id)
    //    {
    //        return _prodService.GetProductById(id);
    //    }

    //    // POST api/<ProductsController>
    //    [HttpPost]
    //    public void Post([FromBody] Product value)
    //    {
    //        _prodService.AddProduct(value);
    //    }

    //    // PUT api/<ProductsController>/5
    //    [HttpPut("{id}")]
    //    public Product Put(int id, [FromBody] Product value)
    //    {
    //        _prodService.UpdateProduct(id, value);
    //        return value;

    //    }

    //    // DELETE api/<ProductsController>/5
    //    [HttpDelete("{id}")]
    //    public void Delete(int id)
    //    {
    //        _prodService.DeleteProduct(id);
    //    }
    //}
}
