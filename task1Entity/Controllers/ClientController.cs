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
    public class ClientController : ControllerBase
    {
        AppDbContext _context = new AppDbContext();
       // GET: api/<ClientController>
        [HttpGet]
         [Route("ClientList")]
        public IList<Client> Get()
        {

            return _context.Clients.ToList();
            

        }
        [HttpPost]
        [Route("InsertClient")]
        public IActionResult InsertClient(Client cx)
        {
            if (!ModelState.IsValid) return BadRequest("not a vaild model");
           
                _context.Add(new Client()
                {
                    FullName = cx.FullName,
                    email = cx.email
                });
                _context.SaveChanges();
            
            return Ok();
        }
         // PUT api/<ClientController>/5
         [HttpPut("UpdateClient/{id}")]
        public IActionResult Update(int id, Client cx)
        {
            if (!ModelState.IsValid) return BadRequest("not a vaild model");
            var client = _context.Clients.Where(x => x.ClientId == id).FirstOrDefault();
            if (client == null)
            {
                return BadRequest("there's no client with this is");
            }
            else
            {
                client.FullName = cx.FullName;
                client.email = cx.email;
                _context.SaveChanges();

                return Ok();
            }
        }
        // DELETE api/<ClientController>/5
        [HttpDelete("DeleteClient/{id}")]
        public IActionResult Delete(int id)
        {
            var client = _context.Clients.Where(x => x.ClientId == id).FirstOrDefault();
            if (client == null)
            {
                return BadRequest("there's no client with this is");
            }
            _context.Remove(client);
            _context.SaveChanges();
            return Ok();
        }


    }
}