using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Models.Entities
{
    public class Invoice
    {
        public Guid Id { get; protected set; }
        public Guid ContractId { get; protected set; }
        public DateTime DateStart { get; protected set; }
        public DateTime DateEnd { get; protected set; }
        public decimal Sum { get; protected set; }

        public Contract Contract { get; protected set; }
    }
}
