using Supermarket.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Models.DTO
{
    public class Shift
    {
        public int Id { get; set; }
        public WorkingDays WorkingDays { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
