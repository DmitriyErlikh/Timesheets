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
    public class EmployeeController : ControllerBase
    {
        public List<Employee> Employees = new List<Employee>();

        [HttpGet("reademployeelist")]
        public IActionResult GetEmployeeList()
        {
            foreach (var employee in Employees)
            {
                Console.WriteLine(employee);
            }
            return Ok();
        }

        [HttpPut("createemployee")]
        public IActionResult CreateEmployee([FromQuery] Employee employee)
        {
            Employees.Add(employee);
            return Ok(0);
        }

        [HttpDelete("deleteemployee")]
        public IActionResult DeleteEmployee([FromQuery] Employee employee)
        {
            Employees.Remove(employee);
            return Ok(0);
        }
    }
}
