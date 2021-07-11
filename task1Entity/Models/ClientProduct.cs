using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task1Entity.Models
{
   
    public class ClientProduct
    {
        public int ClientId { get; set; } 
        public Client Client { get; set; } 

        public int ProductId { get; set; } 
        public Product Product { get; set; }

        public int quantity { get; set; }
    }
}
