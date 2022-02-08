using Supermarket.Models.DTO;
using Supermarket.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Models.Request
{
    public class ShiftUpdateRequest
    {
        public int Id { get; set; }
        public WorkingDays workingDays { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
