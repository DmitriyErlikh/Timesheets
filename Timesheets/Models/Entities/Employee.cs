using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Models.Entities
{   
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid Salary { get; set; }

        public List<Employee> Employees = new List<Employee>();
    }
}
