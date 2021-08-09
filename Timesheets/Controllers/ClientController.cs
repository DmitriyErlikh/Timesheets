using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Models.Entities;

namespace Timesheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClientController : ControllerBase
    {
        public List<Client> Clients = new List<Client>();

        [HttpGet("readclientlist")]
        public IActionResult GetClientList()
        {
            foreach(var client in Clients)
            {
                Console.WriteLine(client);
            }
            return Ok();
        }      

        [HttpPut("createclient")]
        public IActionResult CreateClient([FromQuery] Client client)
        {
            Clients.Add(client);
            return Ok(0);
        }

        [HttpDelete("deleteclient")]
        public IActionResult DeleteClient([FromQuery] Client client)
        {
            Clients.Remove(client);
            return Ok(0);
        }
    }
}
