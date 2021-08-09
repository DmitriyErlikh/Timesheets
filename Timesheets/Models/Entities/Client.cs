using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Models.Entities
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Client> Clients = new List<Client>();
    }
}
