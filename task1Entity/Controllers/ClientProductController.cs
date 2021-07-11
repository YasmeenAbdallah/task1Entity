using Microsoft.AspNetCore.Mvc;
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
    public class ClientProductController : ControllerBase
    {
        AppDbContext _context = new AppDbContext();
        // GET: api/<ClientProductController>
        [HttpGet]
        public IEnumerable<ClientProduct> Get()
        {
            return _context.ClientProducts.ToList();
        }

        // GET api/<ClientProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientProductController>
        [HttpPost]
        public IActionResult Post(ClientProduct obj )
        {

            if (!ModelState.IsValid) return BadRequest("not a vaild model");



            _context.Add(obj);
            _context.SaveChanges();
            //_context.Add(new Product)
            return Ok();
        }

        // PUT api/<ClientProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
