using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task1Entity.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace task1Entity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        AppDbContext _context = new AppDbContext();
        // GET: api/<ClientController>
        [HttpGet]
        [Route("ProductList")]
        public IList<Product> Get()
        {

            return _context.Products.ToList();


        }
        [HttpPost]
        [Route("InsertProduct")]
        public IActionResult InsertClient(Product p)
        {
            if (!ModelState.IsValid) return BadRequest("not a vaild model");

            _context.Add(new Product()
            {
              ProductName=p.ProductName
              
            });
            _context.SaveChanges();

            return Ok();
        }
        // PUT api/<ClientController>/5
        [HttpPut("UpdateProduct/{id}")]
        public IActionResult Put(int id, Product p)
        {
            if (!ModelState.IsValid) return BadRequest("not a vaild model");
            var Product = _context.Products.Where(x => x.ProductId == id).FirstOrDefault();
            if (Product == null)
            {
                return BadRequest("there's no client with this is");
            }
            else
            {
                Product.ProductName = p.ProductName;
                _context.SaveChanges();

                return Ok();
            }
        }
        // DELETE api/<ClientController>/5
        [HttpDelete("DeleteProduct/{id}")]
        public IActionResult Delete(int id)
        {
            var Product = _context.Products.Include(x=>x.ClientProduct).Where(x => x.ProductId == id).FirstOrDefault();
            if (Product == null)
            {
                return BadRequest("there's no client with this is");
            }
            if(Product.ClientProduct != null && Product.ClientProduct.Count >0)
            {
                return BadRequest("The product is already used in system");
            }
            _context.Remove(Product);
            _context.SaveChanges();
            return Ok();
        }
    }
}
