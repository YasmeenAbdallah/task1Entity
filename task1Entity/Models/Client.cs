using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task1Entity.Models
{
    public class Client
    {
       
        public int ClientId { get; set; }
        public string  FullName { get; set; }
        public string email { get; set; }
        public virtual ICollection<ClientProduct> ClientProduct { get; set; }
    }
}
